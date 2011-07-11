using System;
using Rhino.ServiceBus.Sagas;

namespace HibernatingRhinos.Macto.Models.Processes.Messages
{
    public class InmateRejected : ISagaMessage
    {
        public Guid CorrelationId { get; set; }
    }
}