using Bridge;
namespace BridgeTest
{
	[TestClass]
	public class BridgeTests
	{
		#region Test Base Price and Vehicle Type
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

		[TestMethod]
		public void TestBrobizzCar()
		{
			//Arrange
			Vehicle car = new Car();

			//Act
			double priceDiscounted = car.Price(true);

			//Assert
			Assert.AreEqual(207, priceDiscounted);
		}

		[TestMethod]
		public void TestBrobizzMC()
		{
			//Arrange
			Vehicle mc = new MC();

			//Act
			double priceDiscounted = mc.Price(true);

			//Assert
			Assert.AreEqual(108, priceDiscounted);
		}
	}
}
