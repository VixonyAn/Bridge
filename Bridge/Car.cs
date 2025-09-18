namespace Bridge
{
    public class Car
	{
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        public double Price()
        {
            return 230;
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
}
