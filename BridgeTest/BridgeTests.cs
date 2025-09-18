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
	}
}
