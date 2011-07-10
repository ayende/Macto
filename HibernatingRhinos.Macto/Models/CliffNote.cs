namespace HibernatingRhinos.Macto.Models
{
    public class CliffNote
    {
        public string ReportingOfficerId { get; set; }
        public string Reason { get; set; }
        public ReportType ReportType { get; set; }
        public string Report { get; set; }
    }
}