using System;

namespace Macto.Domain
{
    public class Flag
    {
        public string Reason { get; set; }
        public FlagType FlagType { get; set; }

        // Should Fix Reqiuired for Flag also be a enum?
        public string FixRequired { get; set; }

        public DateTime FlaggedDate { get; set; }
        public bool IsFixed { get; set; }
        public DateTime FixedDate { get; set; }
    }
}