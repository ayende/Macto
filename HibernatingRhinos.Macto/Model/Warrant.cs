using System;

namespace Macto.Domain
{
    public class Warrant
    {
        public WarrantType WarrantType { get; set; }
        public IssuingAuthority IssuingAuthority { get; set; }
        public string Issuer { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }	// Store along with duration for ease of querying
        public TimeSpan Duration { get; set; }		// Store along with expiry date for ease of review
        public string DocumentLocation { get; set; }	// RavenDb Attachment?
    }
}