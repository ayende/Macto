using System;

namespace HibernatingRhinos.Macto.Models.Warrants
{
    public abstract class Warrant
    {
        public string IssuerId { get; set; }
        public DateTime IssueAt { get; set; }
        public DateTime EffectiveFrom{ get; set; }

        public string ScanLocationUrl { get; set; }

		// this id is relevant only within the scope a dossier
    	public int LocalId { get; set; }
    }
}