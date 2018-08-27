using RoomAreaCalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoomAreaCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DataRow(5, 5, 25)]
        [DataRow(0, 10, 0)]
        [DataRow(10, 10, 100)]
        [DataRow(2, 3, 6)]
        [DataRow(0, 0, 0)]
        [DataRow(100, 210, 21000)]
        [DataRow(80, 69, 5520)]
        [DataRow(0.8, 0.655, 0.524)]
        public void Test_CalculateFloorArea(double width, double length, double expectedArea)
        {
            // Act
            double actualArea = Calculator.CalculateFloorArea(width, length);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [DataTestMethod]
        [DataRow(5, 5, 5, 125)]
        [DataRow(0, 10, 5, 0)]
        [DataRow(10, 10, 10, 1000)]
        [DataRow(2, 3, 4, 24)]
        [DataRow(0, 0, 0, 0)]
        [DataRow(100, 210, 167, 3507000)]
        [DataRow(80, 69, 2, 11040)]
        [DataRow(0.8, 0.655, 0.287, 0.150388)]
        public void Test_CalculateRoomVolume(double width, double length, double height, double expectedVolume)
        {
            // Act
            double actualVolume = Calculator.CalculateRoomVolume(width, length, height);

            // Assert
            Assert.AreEqual(expectedVolume, actualVolume);
        }

        [DataTestMethod]
        [DataRow(5, 5, 5, 100)]
        [DataRow(0, 10, 5, 100)]
        [DataRow(10, 10, 10, 400)]
        [DataRow(2, 3, 4, 40)]
        [DataRow(0, 0, 0, 0)]
        [DataRow(100, 210, 167, 103540)]
        [DataRow(80, 69, 2, 596)]
        [DataRow(0.8, 0.655, 0.287, 0.83517)] 
        public void Test_CalculatePaintRequired(double width, double length, double height, double expectedPaint)
        {
            // Act
            double actualPaint = Calculator.CalculatePaintRequired(width, length, height);

            // Assert
            Assert.AreEqual(expectedPaint, actualPaint);
        }
    }
}