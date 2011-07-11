using System;
using Rhino.ServiceBus.Sagas;

namespace HibernatingRhinos.Macto.Models.Processes.Messages
{
    public class InmateAccepted : ISagaMessage
    {
        public Guid CorrelationId { get; set; }
        public string InmateId { get; set; }
    }
}