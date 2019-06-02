using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetCircleSquare_PositiveRadius()
        {
            Assert.AreEqual(4 * Math.PI, TestProject.GetCircleSquare(2), "Incorrect circle square.");
        }
        [TestMethod]
        public void GetCircleSquare_NegativeRadius()
        {
            Assert.ThrowsException<Exception>(() => TestProject.GetCircleSquare(-1), "Exception message expected.");
        }
        [TestMethod]
        public void GetTriangleSquare_CorrectTriangle()
        {
            Assert.AreEqual(6, TestProject.GetTriangleSquare(3, 4, 5), "Incorrect triangle square.");
        }
        [TestMethod]
        public void GetTriangleSquare_IncorrectTriangle()
        {
            Assert.ThrowsException<Exception>(() => TestProject.GetTriangleSquare(2, 4, 7), "Exception message expected.");
        }

        [TestMethod]
        public void IsRightTriangle_true()
        {
            Assert.AreEqual(true, TestProject.IsRightTriangle(3, 4, 5));
        }

        [TestMethod]
        public void IsRightTriangle_false()
        {
            Assert.AreEqual(false, TestProject.IsRightTriangle(4, 5, 6));
        }
    }
}
