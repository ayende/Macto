using System.Collections.Generic;

namespace HibernatingRhinos.Macto.Models
{
    public class Location
    {
        public string Id { get; set; }
        public string Name { get; set; }

		public ICollection<string> Roster { get; set; }

    	public Location()
    	{
			Roster = new List<string>();
    	}
    }
}