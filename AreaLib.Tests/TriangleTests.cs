using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaLib.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetAreaTest()
        {
            double sideA = 4;
            double sideB = 5;
            double sideC = 3;

            double expected = 6;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIsRightTriangleTest()
        {
            double sideA = 6;
            double sideB = 8;
            double sideC = 10;

            bool expected = true;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool actual = triangle.isRightTriangle;

            Assert.AreEqual(expected, actual);
        }
    }
}
