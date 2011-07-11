using System.Collections.Generic;
using Raven.Client;

namespace HibernatingRhinos.Macto.Models.Processes
{
    public class AcceptInmateProcess : ISaga<AcceptInmateState>
    {
        public IDocumentSession Session { get; set; }

        public AcceptInmateState State { get; set; }
        public bool IsCompleted { get; set; }

        public AcceptInmateProcess()
        {
            State = new AcceptInmateState();
        }

        private void InitialiseState()
        {
            if (State.Id != null)
                State = Session.Load<AcceptInmateState>(State.Id);
        }

        public void Consume(NewInmateArrived newInmateArrived)
        {
            InitialiseState();

            var inmate = new Inmate()
                             {
                                 FirstName = newInmateArrived.FirstName,
                                 Surname = newInmateArrived.LastName
                             };
            Session.Store(inmate);

            var inmateRecord = new InmateRecord()
                                   {
                                       InmateId = inmate.Id,
                                       LocationId = newInmateArrived.LocationId,
                                       CliffNotes = new List<CliffNote>(),
                                       StickyNotes = new List<StickyNote>()
                                   };
            Session.Store(inmateRecord);

            var dossier = new Dossier()
                              {
                                  InmateId = inmate.Id,
                                  FlagReasons = new List<Flag>(),
                                  IsFlagged = false,
                                  Warrants = new List<Warrant>()
                              };
            Session.Store(dossier);

            AcceptInmateIfDone();
        }

        public void Consume(WarrantsReceived warrantsReceived)
        {
            InitialiseState();

            var dossier = Session.Load<Dossier>(State.DossierId);

            foreach (var warrant in warrantsReceived.Warrants)
            {
                dossier.AddWarrant(warrant);
            }

            State.HaveChainOfIncarceration = dossier.HasValidChainOfIncarceration();
            AcceptInmateIfDone();
        }

	    public void Consume(InmateRejected inmateRejected)
	    {
	        InitialiseState();
	        // What do we do when an inmate is rejected?
	    }

	    private void AcceptInmateIfDone()
        {
            if (State.InmateIdentified && State.HaveChainOfIncarceration)
                IsCompleted = true;
        }
    }
}