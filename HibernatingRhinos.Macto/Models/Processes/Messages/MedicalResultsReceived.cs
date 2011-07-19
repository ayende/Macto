using System;
using Rhino.ServiceBus.Sagas;

namespace HibernatingRhinos.Macto.Models.Processes.Messages
{
    public class MedicalResultsReceived : ISagaMessage
    {
        public Guid CorrelationId { get; set; }
        public bool PassedMedical { get; set; }
        public AttachmentReference ScanAttachmentId { get; set; }
    }
}