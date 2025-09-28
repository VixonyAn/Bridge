
namespace StoreBaeltTicketLibrary
{
	public interface ITicketRepository
	{
		StoreBaeltCar CreateTicket(StoreBaeltCar carTicket);
		List<StoreBaeltCar> GetAllTickets();
		List<StoreBaeltCar> GetTicketsByLicenseplate(string licenseplate);
	}
}