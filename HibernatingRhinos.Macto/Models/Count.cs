using System;
using System.Collections.Generic;
using System.Linq;

namespace HibernatingRhinos.Macto.Models
{
    public class Count
    {
        public DateTime Started { get; set; }
        public CountState State { get; set; }

        public ICollection<InternalCountLocationReport> InternalCountLocationReports { get; set; }
        public ICollection<ExternalCountLocationReport> ExternalCountLocationReports { get; set; }

        public Count(DateTime started)
        {
            Started = started;
            State = CountState.InProgress;

            InternalCountLocationReports = new List<InternalCountLocationReport>();
            ExternalCountLocationReports = new List<ExternalCountLocationReport>();
        }

        public void ReportInternalCount(Location location, Officer officerInCharge, int inmatesIn, int inmatesOut)
        {
            if (InternalCountLocationReports.Any(report => report.LocationId == location.Id))
                throw new InvalidOperationException("Count already reported for this location");

            InternalCountLocationReports.Add(new InternalCountLocationReport(location, officerInCharge, inmatesIn, inmatesOut));
        }

        public void ReportExternalCount(Location location, Officer officerInCharge, Inmate[] inmates)
        {
            ExternalCountLocationReports.Add(new ExternalCountLocationReport(location, officerInCharge, inmates));
        }
    }
}