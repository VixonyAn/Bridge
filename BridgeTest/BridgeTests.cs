using Bridge;
namespace BridgeTest
{
	[TestClass]
	public class BridgeTests
	{
		#region Test Base Price and Vehicle Type Car
		[TestMethod]
		public void TestBridgePriceCar()
		{
			//Arrange
			Car car = new Car();

			//Act
			double price = car.Price(false);

			//Assert
			Assert.AreEqual(230, price);
		}

		[TestMethod]
		public void TestVehicleTypeCar()
		{
			//Arrange
			Car car = new Car();

			//Act
			string vehicleType = car.VehicleType();

			//Assert
			Assert.AreEqual("Car", vehicleType);
		}
		#endregion

		#region Test Base Price and Vehicle Type MC
		[TestMethod]
		public void TestBridgePriceMC()
		{
			//Arrange
			MC mc = new MC();

			//Act
			double price = mc.Price(false);

			//Assert
			Assert.AreEqual(120, price);
		}

		[TestMethod]
		public void TestVehicleTypeMC()
		{
			//Arrange
			MC mc = new MC();

			//Act
			string vehicleType = mc.VehicleType();

			//Assert
			Assert.AreEqual("MC", vehicleType);
		}
		#endregion

		#region Test Licenseplate Length Exception
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestLicenseplateLengthException()
		{
			//Arrange
			Vehicle mc = new MC("ABC4567O");

			//Act
			string licenseplate = mc.Licenseplate;

			//Assert
			Assert.Fail();
		}
		#endregion

		#region Test Brobizz
		[TestMethod]
		public void TestBrobizzCar()
		{
			//Arrange
			Vehicle car = new Car();

			//Act
			double priceDiscounted = car.Price(true);

			//Assert
			Assert.AreEqual(207, priceDiscounted, 0.001);
		}

		[TestMethod]
		public void TestBrobizzMC()
		{
			//Arrange
			Vehicle mc = new MC();

			//Act
			double priceDiscounted = mc.Price(true);

			//Assert
			Assert.AreEqual(108, priceDiscounted, 0.001);
		}
		#endregion

		#region StoreBaeltTicket Discount Tests
		// Price for a car without weekend discount or brobizz discount
		[TestMethod]
		public void TestStoreBaeltCar()
		{
			//Arrange
			Vehicle car = new StoreBaeltCar(DayOfWeek.Friday);

			//Act
			double price = car.Price(false);

			//Assert
			Assert.AreEqual(230, price, 0.001);
		}

		// Price for a car with weekend discount but not brobizz discount
		[TestMethod]
		public void TestStoreBaeltWeekendCar()
		{
			//Arrange
			Vehicle car = new StoreBaeltCar(DayOfWeek.Sunday);

			//Act
			double price = car.Price(false);

			//Assert
			Assert.AreEqual(195.5, price, 0.001);
		}

		// Price for a car with brobizz discount but not weekend discount
		[TestMethod]
		public void TestStoreBaeltBrobizzCar()
		{
			//Arrange
			Vehicle car = new StoreBaeltCar(DayOfWeek.Tuesday);

			//Act
			double price = car.Price(true);

			//Assert
			Assert.AreEqual(207, price, 0.001);
		}

		// Price for a car with weekend discount and brobizz discount
		[TestMethod]
		public void TestStoreBaeltWeekendAndBrobizzCar()
		{
			//Arrange
			Vehicle car = new StoreBaeltCar(DayOfWeek.Saturday);

			//Act
			double price = car.Price(true);

			//Assert
			Assert.AreEqual(175.95, price, 0.001);
		}
		#endregion
	}
}
