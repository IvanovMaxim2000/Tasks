using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaLib.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetAreaTest()
        {
            double radius = 10;

            double expected = Math.PI * Math.Pow(radius, 2);

            Circle circle = new Circle(radius);
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }
}
