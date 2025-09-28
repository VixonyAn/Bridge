namespace StoreBaeltTicketLibrary
{
	public class TicketRepository : ITicketRepository
	{
		#region Instance Fields
		/// <summary>
		/// Static internal list of all tickets sold to cars crossing Storebaelt
		/// </summary>
		private static List<StoreBaeltCar> _storeBaeltTickets;
		/// <summary>
		/// A private list used to store tickets retrieved by the method GetTicketsByLicenseplate
		/// </summary>
		private List<StoreBaeltCar> _licenseplateTicketList;
		#endregion

		#region Methods
		/// <summary>
		/// A method to create a Car Ticket for crossing StoreBaelt
		/// </summary>
		/// <param name="carTicket">Ticket created by creating a new StoreBaeltCar</param>
		/// <returns>The ticket created</returns>
		public StoreBaeltCar CreateTicket(StoreBaeltCar carTicket)
		{
			_storeBaeltTickets.Add(carTicket);
			return carTicket;
		}
		/// <summary>
		/// Retrieves a list of all sold tickets
		/// </summary>
		/// <returns>A list of all sold tickets</returns>
		public List<StoreBaeltCar> GetAllTickets()
		{
			return _storeBaeltTickets;
		}
		/// <summary>
		/// A method to retrieve all tickets sold to a specific licenseplate
		/// </summary>
		/// <param name="licenseplate">licenseplate cannot exceed 7 characters</param>
		/// <returns>A list of sold tickets with a matching licenseplate</returns>
		public List<StoreBaeltCar> GetTicketsByLicenseplate(string licenseplate)
		{
			foreach (StoreBaeltCar ticket in _storeBaeltTickets)
			{
				if (ticket.Licenseplate == licenseplate)
				{
					_licenseplateTicketList.Add(ticket);
				}
			}
			return _licenseplateTicketList;
		}
		#endregion
	}
}
