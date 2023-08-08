using ShapeSquareCalculator.Shapes.Implementations;

namespace ShapeSquareCalculator.Tests.ShapeTests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(10, 157.08)]
        [TestCase(5, 39.27)]
        [Test]
        public void CircleCalculateSquare_ReturnsCorrectValue(double radius, double expectedSquare)
        {
            var circle = new Circle(radius);
            var square = circle.CalculateSquare();
            Assert.AreEqual(expectedSquare, Math.Round(square, 2));
        }
    }
}
