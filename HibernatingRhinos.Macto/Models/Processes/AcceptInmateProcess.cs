using System.Collections.Generic;
using HibernatingRhinos.Macto.Models.Warrants;

namespace HibernatingRhinos.Macto.Models.Processes
{
    public class AcceptInmateProcess : ISaga<AcceptInmateState>
    {
        public AcceptInmateState State { get; set; }
        public bool IsCompleted { get; set; }

        public AcceptInmateProcess()
        {
            State = new AcceptInmateState();
        }

        public void Consume(NewInmateArrived newInmateArrived)
        {
            var inmate = new Inmate()
                             {
                                 FirstName = newInmateArrived.FirstName,
                                 Surname = newInmateArrived.LastName
                             };
            // Store it

            var inmateRecord = new InmateRecord()
                                   {
                                       InmateId = inmate.Id,
                                       LocationId = newInmateArrived.LocationId,
                                       Notes = new List<Note>(),
                                       StickyNotes = new List<StickyNote>()
                                   };
            // Store it

            var dossier = new Dossier()
                              {
                                  InmateId = inmate.Id,
                                  FlagReasons = new List<Flag>(),
                                  IsFlagged = false,
                                  Warrants = new List<Warrant>()
                              };
            // Store it

           AcceptInmateIfDone();
        }

        public void Consume(WarrantsReceived warrantsReceived)
        {
            foreach (var warrant in warrantsReceived.Warrants)
            {
                // Get the session, load the existing dossier and add the warrant

                // Does the system have the logic to determine if we have all warrants needed?
                // If yes need to implement this
            }

            AcceptInmateIfDone();
        }

	    public void Consume(InmateRejected inmateRejected)
        {
            // What do we do when an inmate is rejected?
        }

	    private void AcceptInmateIfDone()
        {
            if (State.InmateIdentified && State.HaveChainOfIncarceration)
                IsCompleted = true;
        }
    }
}