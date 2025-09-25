using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	public class MC : Vehicle
	{
		/// <summary>
		/// A string of numbers and letters that make up a liscenseplate
		/// </summary>
		public string Licenseplate { get; set; }
		/// <summary>
		/// A date and time, used for time based functions like weekend discounts
		/// </summary>
		public DateTime Date { get; set; }

		public MC() { }
		public MC(string licenseplate) : base(licenseplate)
		{
			Licenseplate = licenseplate;
		}

		/// <summary>
		/// A method that determines and processes discounts to calculate the price to cross the bridge
		/// </summary>
		/// <param name="brobizz">A discount card</param>
		/// <returns>Price as a double</returns>
		public override double Price(bool brobizz)
		{
			if (brobizz)
			{
				return 120 * 0.90;
			}
			else
			{
				return 120;
			}
		}

		/// <summary>
		/// A description of the vehicles type, such as car, truck, or motorcycle
		/// </summary>
		/// <returns>Vehicle type as a string</returns>
		public override string VehicleType()
		{
			return "MC";
		}
	}
}
