using Bridge;
namespace BridgeTest
{
	[TestClass]
	public class BridgeTests
	{
		[TestMethod]
		public void TestBridgePriceCar()
		{
			//Arrange
			Car c1 = new Car();

			//Act
			double price = c1.Price();

			//Assert
			Assert.AreEqual(230, price);
		}

		[TestMethod]
		public void TestVehicleTypeCar()
		{
			//Arrange
			Car c1 = new Car();

			//Act
			string vehicleType = c1.VehicleType();

			//Assert
			Assert.AreEqual("Car", vehicleType);
		}

		[TestMethod]
		public void TestBridgePriceMC()
		{
			//Arrange
			MC mc1 = new MC();

			//Act
			double price = mc1.Price();

			//Assert
			Assert.AreEqual(120, price);
		}

		[TestMethod]
		public void TestVehicleTypeMC()
		{
			//Arrange
			MC mc1 = new MC();

			//Act
			string vehicleType = mc1.VehicleType();

			//Assert
			Assert.AreEqual("MC", vehicleType);
		}
	}
}
