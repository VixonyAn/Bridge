using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	public class MC
	{
		/// <summary>
		/// A string of numbers and letters that make up a liscenseplate
		/// </summary>
		public string Licenseplate { get; set; }
		/// <summary>
		/// A date and time, used for time based functions like weekend discounts
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// A method that can be overwritten to add mathematical functions such as discounts
		/// </summary>
		/// <returns>Price as a double</returns>
		public double Price()
		{
			return 120;
		}

		/// <summary>
		/// A description of the vehicles type, such as car, truck, or motorcycle
		/// </summary>
		/// <returns>Vehicle type as a string</returns>
		public string VehicleType()
		{
			return "MC";
		}
	}
}
