using ShapeSquareCalculator.Shapes.Implementations;
using ShapeSquareCalculator.ShapesCreators.Implementations;

namespace ShapeSquareCalculator.Tests
{
    [TestFixture]
    public class ShapeCreatorsTests
    {
        [Test]
        public void CreateCircle_ReturnsCorrectType() 
        {
            var creator = new CircleCreator(5);
            var shape = creator.CreateShape();
            Assert.IsTrue(shape is Circle);
        }

        [Test]
        public void CreateTriangle_ReturnsCorrectType()
        {
            var creator = new TriangleCreator(3, 4, 5);
            var shape = creator.CreateShape();
            Assert.IsTrue(shape is Triangle);
        }
    }
}
