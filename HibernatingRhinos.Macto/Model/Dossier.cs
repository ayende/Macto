using System;
using System.Collections.Generic;

namespace Macto.Domain
{
    public class Dossier
    {
        public Inmate Inmate { get; set; }

        public ICollection<Warrant> Warrants { get; set; }
        public bool IsFlagged { get; set; }
        public ICollection<Flag> FlagReasons { get; set; }

        public Dossier()
        {
            Warrants = new List<Warrant>();
            FlagReasons = new List<Flag>();
        }
    }
}