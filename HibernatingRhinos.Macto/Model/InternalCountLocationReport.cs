using System;

namespace Macto.Domain
{
    public class InternalCountLocationReport
    {
        public string LocationId { get; set; }
        public string OfficerInChargeId { get; set; }
        public int RosterCount { get; set; }
        public int InmatesIn { get; set; }
        public int InmatesOut { get; set; }

        public InternalCountLocationReport(Location location, Officer officerInCharge, int inmatesIn, int inmatesOut)
        {
            LocationId = location.Id;
            OfficerInChargeId = officerInCharge.Id;
            InmatesIn = inmatesIn;
            InmatesOut = inmatesOut;
            RosterCount = location.RosterCount;
        }
    }
}