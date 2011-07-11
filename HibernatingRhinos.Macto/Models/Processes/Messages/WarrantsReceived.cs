using System;
using System.Collections.Generic;
using Rhino.ServiceBus.Sagas;

namespace HibernatingRhinos.Macto.Models.Processes.Messages
{
    public class WarrantsReceived : ISagaMessage
    {
        public Guid CorrelationId { get; set; }
        public ICollection<Warrant> Warrants { get; set; }
    }
}