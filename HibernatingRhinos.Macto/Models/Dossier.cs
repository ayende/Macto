using System;
using System.Collections.Generic;

namespace HibernatingRhinos.Macto.Models
{
    public class Dossier
    {
        public string InmateId { get; set; }

        public ICollection<Warrant> Warrants { get; set; }
        public bool IsFlagged { get; set; }
        public ICollection<Flag> FlagReasons { get; set; }

        public Dossier()
        {
            Warrants = new List<Warrant>();
            FlagReasons = new List<Flag>();
        }

		private int LastWarrantId { get; set; }

		public void AddWarrant(Warrant warrant)
		{
			warrant.LocalId = ++LastWarrantId;
			Warrants.Add(warrant);
		}
    }
}