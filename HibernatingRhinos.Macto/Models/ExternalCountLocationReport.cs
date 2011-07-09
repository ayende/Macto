using System.Collections.Generic;
using System.Linq;

namespace HibernatingRhinos.Macto.Models
{
    public class ExternalCountLocationReport
    {
        public string LocationId { get; set; }
        public string OfficerInChargeId { get; set; }
        public ICollection<string> InmateIds { get; set; }

        public ExternalCountLocationReport(Location location, Officer officerInCharge, IEnumerable<Inmate> inmates)
        {
            InmateIds = new List<string>();

            LocationId = location.Id;
            OfficerInChargeId = officerInCharge.Id;
            InmateIds = inmates.Select(inmate => inmate.Id).ToList();
        }
    }
}