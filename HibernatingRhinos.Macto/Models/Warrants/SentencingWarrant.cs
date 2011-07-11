using System;

namespace HibernatingRhinos.Macto.Models.Warrants
{
	public class SentencingWarrant : Warrant
	{

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