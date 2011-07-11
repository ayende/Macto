using System;

namespace HibernatingRhinos.Macto.Models
{
    public class Warrant
    {
        public string IssuerId { get; set; }
        public DateTime IssueAt { get; set; }
        public DateTime EffectiveFrom{ get; set; }
        public WarrantType Type { get; set; }

        public string ScanLocationUrl { get; set; }

		// this id is relevant only within the scope a dossier
    	public int LocalId { get; set; }

        public DateTime ExpiredAt // sould make querying easier
        {
            get
            {
                return EffectiveFrom.Add(Duration);
            }
        }
        public TimeSpan Duration { get; set; }		// Store along with expiry date for ease of review
    }
}