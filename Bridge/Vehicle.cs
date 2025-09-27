namespace Bridge
{
	public abstract class Vehicle
	{
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
		/// <summary>
		/// An empty constructor for creating a Vehicle
		/// </summary>
		public Vehicle() { }
		/// <summary>
		/// A contructor for creating a Vehicle, requiring a license plate
		/// </summary>
		/// <param name="licenseplate">Licenseplate may not exceed 7 characters</param>
		/// <exception cref="ArgumentException">Licenseplate may not exceed 7 characters</exception>
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
		public abstract double Price(bool brobizz);

		/// <summary>
		/// A description of the vehicles type, such as car, truck, or motorcycle
		/// </summary>
		/// <returns>Vehicle type as a string</returns>
		public abstract string VehicleType();
		#endregion
	}
}
