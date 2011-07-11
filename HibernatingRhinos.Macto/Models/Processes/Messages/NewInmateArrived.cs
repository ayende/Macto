using System;
using Rhino.ServiceBus.Sagas;

namespace HibernatingRhinos.Macto.Models.Processes.Messages
{
    public class NewInmateArrived : ISagaMessage
    {
        public Guid CorrelationId { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string LocationId { get; set; }
    }
}