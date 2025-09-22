using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	public abstract class Vehicle
	{
		#region Instance Fields
		private string licenseplate;
		#endregion

		#region Properties
		/// <summary>
		/// A string of numbers and letters that make up a licenseplate
		/// </summary>
		public string Licenseplate { get; set; }
		/// <summary>
		/// A date and time, used for time based functions like weekend discounts
		/// </summary>
		public DateTime Date { get; set; }
		#endregion

		#region Constructors
		public Vehicle() { }
		public Vehicle(string licenseplate)
		{
			if (licenseplate.Length > 7)
			{
				throw new ArgumentException("Licenseplate may not exceed 7 characters");
			}
			Licenseplate = licenseplate;
		}

		#endregion

		#region Methods
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
		#endregion
	}
}
