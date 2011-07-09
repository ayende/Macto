namespace HibernatingRhinos.Macto.Models
{
    public class Note
    {
        public Officer ReportingOfficer { get; set; }
        public string Reason { get; set; }
        public ReportType ReportType { get; set; }
        public string Report { get; set; }

        public bool IsCliffNote { get; set; }
    }
}