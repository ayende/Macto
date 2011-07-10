using System;

namespace HibernatingRhinos.Macto.Models
{
    public class LocationHistory
    {
        public LocationHistory()
        {
        }

        public LocationHistory(string locationId, DateTime startDate, DateTime endDate)
        {
            LocationId = locationId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string LocationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}