using System.Collections.Generic;

namespace HibernatingRhinos.Macto.Models.Processes.Messages
{
    public class WarrantsReceived
    {
        public ICollection<Warrant> Warrants { get; set; }
    }
}