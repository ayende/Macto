using System.Collections.Generic;
using HibernatingRhinos.Macto.Models.Warrants;

namespace HibernatingRhinos.Macto.Models.Processes
{
    public class WarrantsReceived
    {
        public ICollection<Warrant> Warrants { get; set; }
    }
}