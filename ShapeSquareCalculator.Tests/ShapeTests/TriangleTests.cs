using ShapeSquareCalculator.Shapes.Implementations;

namespace ShapeSquareCalculator.Tests.ShapeTests
{
    public class TriangleTests
    {
        [TestCase(6, 8, 10, 24)]
        [TestCase(5, 12, 13, 30)]
        [Test]
        public void TriangleCalculateSquare_ReturnsCorrectValue(double a, double b, double c, double expectedSquare)
        {
            var triangle = new Triangle(a, b, c);
            var square = triangle.CalculateSquare();
            Assert.AreEqual(expectedSquare, square);
        }

        [Test]
        public void TriangleIsRight_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRight);
        }

        [Test]
        public void TriangleIsRight_ReturnsFalse()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRight);
        }
    }
}
