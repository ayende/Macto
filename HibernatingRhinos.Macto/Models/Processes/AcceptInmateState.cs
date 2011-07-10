namespace HibernatingRhinos.Macto.Models.Processes
{
	public class AcceptInmateState
	{
	    public string Id { get; set; }
	    public string DossierId { get; set; }
	    public bool InmateIdentified { get; set; }
	    public bool HaveChainOfIncarceration { get; set; }
	}
}