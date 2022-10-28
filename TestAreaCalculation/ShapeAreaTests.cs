using AreaCalculation;

namespace TestSquareCalculation
{
    [TestClass]
    public class ShapeAreaTests
    {
        [TestMethod]
        public void IsCircleAreaCorrect()
        {
            Assert.AreEqual(Math.PI, ShapeUtilities.GetCircleArea(1));
            Assert.AreEqual(Math.PI * 9, ShapeUtilities.GetCircleArea(3));
        }

        [TestMethod]
        public void IsInputValid()
        {
            Assert.ThrowsException<ArgumentException>(() => ShapeUtilities.GetCircleArea(0));
            Assert.ThrowsException<ArgumentException>(() => ShapeUtilities.GetCircleArea(-1));

            Assert.ThrowsException<ArgumentException>(() => ShapeUtilities.GetTriangleAreaBySides(0, 1, 1));
            Assert.ThrowsException<ArgumentException>(() => ShapeUtilities.GetTriangleAreaBySides(1, 0, 1));
            Assert.ThrowsException<ArgumentException>(() => ShapeUtilities.GetTriangleAreaBySides(1, 1, 0));

            Assert.ThrowsException<ArgumentException>(() => ShapeUtilities.GetTriangleAreaBySides(-1, 1, 1));
            Assert.ThrowsException<ArgumentException>(() => ShapeUtilities.GetTriangleAreaBySides(1, -1, 1));
            Assert.ThrowsException<ArgumentException>(() => ShapeUtilities.GetTriangleAreaBySides(1, 1, -1));

            Assert.ThrowsException<ArgumentException>(() => ShapeUtilities.GetTriangleAreaBySides(1, 2, 4));
        }

        [TestMethod]
        public void IsTriangleAreaCorrect()
        {
            Assert.AreEqual(6.0, ShapeUtilities.GetTriangleAreaBySides(3, 4, 5));
            Assert.AreEqual(3.897114317029974, ShapeUtilities.GetTriangleAreaBySides(3, 3, 3));
        }

        [TestMethod]
        public void IsRight_Correct()
        {
            Assert.IsTrue(new Triangle(4, 3, 5).IsRight());
            Assert.IsFalse(new Triangle(3, 3, 3).IsRight());
        }
    }
}