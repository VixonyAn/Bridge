namespace Bridge
{
    public class Car : Vehicle
	{
		#region Constructors
		/// <summary>
		/// An empty constructor for creating a Car
		/// </summary>
		public Car() { }
		/// <summary>
		/// A contructor for creating a Car, requiring a license plate
		/// </summary>
		/// <param name="licenseplate">Licenseplate may not exceed 7 characters</param>
		public Car(string licenseplate) : base(licenseplate)
		{
			Licenseplate = licenseplate;
		}
		#endregion

		#region Methods
		/// <summary>
		/// A method that determines and processes discounts to calculate the price to cross the bridge
		/// </summary>
		/// <param name="brobizz">A discount card</param>
		/// <returns>Price as a double</returns>
		public override double Price(bool brobizz)
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

		/// <summary>
		/// A description of the vehicles type, such as car, truck, or motorcycle
		/// </summary>
		/// <returns>Vehicle type as a string</returns>
		public override string VehicleType()
        {
            return "Car";
        }
		#endregion
	}
}
