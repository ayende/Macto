using System.Collections.Generic;

namespace HibernatingRhinos.Macto.Models.Processes
{
    public class WarrantsReceived
    {
        public ICollection<Warrant> Warrants { get; set; }
    }
}