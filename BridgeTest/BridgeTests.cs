using Bridge;
using StoreBaeltTicketLibrary;
using OresundTicketLibrary;
namespace BridgeTest
{
	[TestClass]
	public class BridgeTests
	{
		#region Test Base Price and Vehicle Type Car
		//Testing base price for Car
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

		//Testing that vehicletype returns Car
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
		//Testing base price for MC
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

		//Testing that vehicletype returns MC
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
		//Testing that an exception is thrown when a licenseplate is longer than 7 characters
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
		//Price for a Car with brobizz discount
		[TestMethod]
		public void TestBrobizzPriceCar()
		{
			//Arrange
			Vehicle car = new Car();

			//Act
			double priceDiscounted = car.Price(true);

			//Assert
			Assert.AreEqual(207, priceDiscounted, 0.001);
		}

		//Price for a MC with brobizz discount
		[TestMethod]
		public void TestBrobizzPriceMC()
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
		//Price for a car without weekend discount or brobizz discount
		[TestMethod]
		public void TestStoreBaeltPriceCar()
		{
			//Arrange
			Vehicle car = new StoreBaeltCar(DayOfWeek.Friday);

			//Act
			double price = car.Price(false);

			//Assert
			Assert.AreEqual(230, price, 0.001);
		}

		//Price for a car with weekend discount but not brobizz discount
		[TestMethod]
		public void TestStoreBaeltWeekendPriceCar()
		{
			//Arrange
			Vehicle car = new StoreBaeltCar(DayOfWeek.Sunday);

			//Act
			double price = car.Price(false);

			//Assert
			Assert.AreEqual(195.5, price, 0.001);
		}

		//Price for a car with brobizz discount but not weekend discount
		[TestMethod]
		public void TestStoreBaeltBrobizzPriceCar()
		{
			//Arrange
			Vehicle car = new StoreBaeltCar(DayOfWeek.Tuesday);

			//Act
			double price = car.Price(true);

			//Assert
			Assert.AreEqual(207, price, 0.001);
		}

		//Price for a car with weekend discount and brobizz discount
		[TestMethod]
		public void TestStoreBaeltWeekendAndBrobizzPriceCar()
		{
			//Arrange
			Vehicle car = new StoreBaeltCar(DayOfWeek.Saturday);

			//Act
			double price = car.Price(true);

			//Assert
			Assert.AreEqual(175.95, price, 0.001);
		}
		#endregion

		#region Oresund Price and Vehicle Type Tests
		//Testing that vehicletype returns Oresund Car
		[TestMethod]
		public void TestVehicleTypeOresundCar()
		{
			//Arrange
			Vehicle car = new OresundCar();

			//Act
			string vehicleType = car.VehicleType();

			//Assert
			Assert.AreEqual("Oresund Car", vehicleType);
		}

		//Testing that vehicletype returns Oresund MC
		[TestMethod]
		public void TestVehicleTypeOresundMC()
		{
			//Arrange
			Vehicle mc = new OresundMC();

			//Act
			string vehicleType = mc.VehicleType();

			//Assert
			Assert.AreEqual("Oresund MC", vehicleType);
		}

		//Price for a Oresund Car without brobizz
		[TestMethod]
		public void TestOresundPriceCar()
		{
			//Arrange
			Vehicle car = new OresundCar();

			//Act
			double price = car.Price(false);

			//Assert
			Assert.AreEqual(460, price, 0.001);
		}

		//Price for a Oresund Car with brobizz discount
		[TestMethod]
		public void TestOresundBrobizzPriceCar()
		{
			//Arrange
			Vehicle car = new OresundCar();

			//Act
			double price = car.Price(true);

			//Assert
			Assert.AreEqual(178, price, 0.001);
		}

		//Price for a Oresund MC without brobizz
		[TestMethod]
		public void TestOresundPriceMC()
		{
			//Arrange
			Vehicle mc = new OresundMC();

			//Act
			double price = mc.Price(false);

			//Assert
			Assert.AreEqual(235, price, 0.001);
		}

		//Price for a Oresund MC with brobizz discount
		[TestMethod]
		public void TestOresundBrobizzPriceMC()
		{
			//Arrange
			Vehicle mc = new OresundMC();

			//Act
			double price = mc.Price(true);

			//Assert
			Assert.AreEqual(92, price, 0.001);
		}
		#endregion
	}
}
