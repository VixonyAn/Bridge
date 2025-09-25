using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bridge
{
    public class StoreBaeltCar : Car
	{
		public DayOfWeek Weekday { get; set; }
		public double TicketPrice { get; set; }

		public StoreBaeltCar() { }
		public StoreBaeltCar(DayOfWeek weekday)
		{
			Weekday = weekday;
		}

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
