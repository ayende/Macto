using System;

namespace HibernatingRhinos.Macto.Models
{
    public class Flag
    {
        public string Reason { get; set; }
        public FlagType FlagType { get; set; }

        // Should Fix Required for Flag also be a enum?
        public string FixRequired { get; set; }

        public DateTime FlaggedDate { get; set; }
        public bool IsFixed { get; set; }
        public DateTime FixedDate { get; set; }

        // You can suppress a specific Flag by adding a warrant that allows it
        public Warrant Suppression { get; set; }
    }
}