namespace HibernatingRhinos.Macto.Models
{
    public class Court : IIssuingAuthority
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}