using System;
using Rhino.ServiceBus.Sagas;

namespace HibernatingRhinos.Macto.Models.Processes.Messages
{
    public class IntelligenceReportReceived : ISagaMessage
    {
        public Guid CorrelationId { get; set; }
        public string ScanAttachmentId { get; set; }
    }
}