namespace HibernatingRhinos.Macto.Models
{
    public class Officer : IIssuingAuthority
    {
        public string Id { get; set; }
        public OfficerRank Rank { get; set; }
        public OfficerPosition Position { get; set; }
        public string Name { get; set; }
    }
}