using System.Collections.Generic;

namespace HibernatingRhinos.Macto.Models
{
    public class Prison
    {
        public ICollection<Location> Locations { get; set; }
    }
}