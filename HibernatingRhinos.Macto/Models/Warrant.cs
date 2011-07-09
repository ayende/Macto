using System;

namespace HibernatingRhinos.Macto.Models
{
    public abstract class Warrant
    {
        public IIssuingAuthority Issuer { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string DocumentLocation { get; set; }

		// this id is relevant only within the scope a dossier
    	public int LocalId { get; set; }

// RavenDb Attachment?
    }

    public class ArrestWarrant : Warrant
    {
        public DateTime ExpiryDate { get; set; }	// Store along with duration for ease of querying
        public TimeSpan Duration { get; set; }		// Store along with expiry date for ease of review
    }

    public class DetentionWarrant : Warrant
    {
        public DateTime ExpiryDate { get; set; }	// Store along with duration for ease of querying
        public TimeSpan Duration { get; set; }		// Store along with expiry date for ease of review
    }

    public class RemandWarrant : Warrant
    {
    }

    public class SentencingWarrant : Warrant
    {
        public DateTime ExpiryDate { get; set; }	// Store along with duration for ease of querying
        public TimeSpan Duration { get; set; }		// Store along with expiry date for ease of review
    }
}