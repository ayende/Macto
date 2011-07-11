using System;

namespace HibernatingRhinos.Macto.Models.Processes
{
    public class NewInmateArrived
    {
        public string FullName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string LocationId { get; set; }
    }
}