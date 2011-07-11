using System;
using System.Collections.Generic;
using HibernatingRhinos.Macto.Models.Processes.Messages;
using Raven.Client;
using Rhino.ServiceBus;
using Rhino.ServiceBus.Sagas;

namespace HibernatingRhinos.Macto.Models.Processes
{
    public class AcceptInmateProcess : 
        ISaga<AcceptInmateState>, 
        InitiatedBy<NewInmateArrived>,
        ConsumerOf<InmateRejected>
    {
        private readonly IDocumentSession _documentSession;
        private readonly IServiceBus _bus;

        public AcceptInmateState State { get; set; }
        public Guid Id { get; set; }

        public bool IsCompleted { get; set; }

        public AcceptInmateProcess(
            IDocumentSession documentSession,
            IServiceBus bus)
        {
            _documentSession = documentSession;
            _bus = bus;
            State = new AcceptInmateState();
        }

        public void Consume(NewInmateArrived newInmateArrived)
        {
            var inmate = new Inmate()
                             {
                                 FullName = newInmateArrived.FullName,
                                 Surname = newInmateArrived.LastName
                             };
            _documentSession.Store(inmate);

            var inmateRecord = new InmateRecord()
                                   {
                                       InmateId = inmate.Id,
                                       LocationId = newInmateArrived.LocationId,
                                       CliffNotes = new List<CliffNote>(),
                                       StickyNotes = new List<StickyNote>()
                                   };
            _documentSession.Store(inmateRecord);

            var dossier = new Dossier()
                              {
                                  InmateId = inmate.Id,
                                  FlagReasons = new List<Flag>(),
                                  IsFlagged = false,
                                  Warrants = new List<Warrant>()
                              };
            _documentSession.Store(dossier);

            AcceptInmateIfDone();
        }

        public void Consume(WarrantsReceived warrantsReceived)
        {
            var dossier = _documentSession.Load<Dossier>(State.DossierId);

            foreach (var warrant in warrantsReceived.Warrants)
            {
                dossier.AddWarrant(warrant);
            }

            State.HaveChainOfIncarceration = dossier.HasValidChainOfIncarceration();
            AcceptInmateIfDone();
        }

	    public void Consume(InmateRejected inmateRejected)
	    {
	        // What do we do when an inmate is rejected?
	    }

	    private void AcceptInmateIfDone()
        {
            if (State.InmateIdentified && State.HaveChainOfIncarceration)
            {
                _bus.Publish(new InmateAccepted() { InmateId = State.InmateId });
                IsCompleted = true;
            }
        }
    }
}