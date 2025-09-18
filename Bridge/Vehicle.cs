using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	public abstract class Vehicle
	{
		/// <summary>
		/// A string of numbers and letters that make up a liscenseplate
		/// </summary>
		public string Licenseplate;
		/// <summary>
		/// A date and time, used for time based functions like weekend discounts
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// A method that determines and processes discounts to calculate the price to cross the bridge
		/// </summary>
		/// <returns>Price as a double</returns>
		public virtual double Price()
		{
			if ("Car" == VehicleType()) { return 230; }
			else if ("MC" == VehicleType()) { return 120; }
			return 0;
		}

		/// <summary>
		/// A description of the vehicles type, such as car, truck, or motorcycle
		/// </summary>
		/// <returns>Vehicle type as a string</returns>
		public abstract string VehicleType();
	}
}
