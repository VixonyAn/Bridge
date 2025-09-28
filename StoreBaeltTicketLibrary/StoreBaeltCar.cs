using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
	{
		#region Properties
		/// <summary>
		/// A date, used for time based functions like weekend discounts
		/// </summary>
		public DayOfWeek Weekday { get; set; }
		/// <summary>
		/// The variable TicketPrice is used in this class to account for math done in the Price method
		/// </summary>
		public double TicketPrice { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// An empty constructor for creating a Storebaelt Car
		/// </summary>
		public StoreBaeltCar() { }
		/// <summary>
		/// A constructor for creating a Storebaelt Car requiring a DayOfWeek to determine the weekend discount
		/// </summary>
		/// <param name="weekday">DayOfWeek</param>
		public StoreBaeltCar(DayOfWeek weekday)
		{
			Weekday = weekday;
		}
		/// <summary>
		/// A constructor for creating a Storebaelt Car requiring a licenseplate and DayOfWeek to determine the weekend discount
		/// </summary>
		/// <param name="weekday">DayOfWeek</param>
		public StoreBaeltCar(DayOfWeek weekday, string licenseplate) : base(licenseplate)
		{
			Weekday = weekday;
			Licenseplate = licenseplate;
		}
		#endregion

		/// <summary>
		/// A method that determines and processes discounts to calculate the price to cross the bridge
		/// </summary>
		/// <param name="brobizz">A discount card</param>
		/// <returns>Price as a double</returns>
		public override double Price(bool brobizz)
		{
			if (Weekday == DayOfWeek.Saturday || Weekday == DayOfWeek.Sunday)
			{
				TicketPrice = 230 * 0.85;
				if (brobizz)
				{
					return TicketPrice * 0.90;
				}
				else
				{
					return TicketPrice;
				}
			}
			else
			{
				if (brobizz)
				{
					return 230 * 0.90;
				}
				else
				{
					return 230;
				}
			}
		}

		/// <summary>
		/// A description of the vehicles type, such as car, truck, or motorcycle
		/// </summary>
		/// <returns>Vehicle type as a string</returns>
		public override string VehicleType()
        {
            return "Car";
        }
    }
}
