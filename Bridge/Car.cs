namespace Bridge
{
    public class Car : Vehicle
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
        /// A description of the vehicles type, such as car, truck, or motorcycle
        /// </summary>
        /// <returns>Vehicle type as a string</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
