using Microsoft.VisualStudio.TestTools.UnitTesting;
using MayJuneFinalExam;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Rental_Increase()
        {
            //Arrange
            RentalProperty r1 = new RentalProperty()
            {
                RentalType = RentalType.House,
                Price = 100m
            };
            decimal expectedPrice = 110m;
            //Act
            r1.IncreaseRent(0.10m);

            //Assert
            Assert.AreEqual(expectedPrice, r1.Price);
        }
    }
}