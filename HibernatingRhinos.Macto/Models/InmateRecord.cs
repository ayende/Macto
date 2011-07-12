using System.Collections.Generic;

namespace HibernatingRhinos.Macto.Models
{
    public class InmateRecord
    {
        public string InmateId { get; set; }

        public ICollection<CliffNote> CliffNotes { get; set; }
        public ICollection<StickyNote> StickyNotes { get; set; }
        public ICollection<LocationHistory> Locations { get; set; }

        public AttachmentReference GuardsReport { get; set; }
        public AttachmentReference IntelligenceReport { get; set; }
        public AttachmentReference DiscipliningActionsReport { get; set; }

        public string LocationId { get; set; }

        public InmateRecord()
        {
            CliffNotes = new List<CliffNote>();
            StickyNotes = new List<StickyNote>();
            Locations = new List<LocationHistory>();
        }
    }
}