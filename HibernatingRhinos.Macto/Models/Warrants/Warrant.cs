using System;

namespace HibernatingRhinos.Macto.Models.Warrants
{
    public abstract class Warrant
    {
        public IIssuingAuthority Issuer { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime EffectiveDate { get; set; }

        public string DocumentLocation { get; set; }

		// this id is relevant only within the scope a dossier
    	public int LocalId { get; set; }
    }
}