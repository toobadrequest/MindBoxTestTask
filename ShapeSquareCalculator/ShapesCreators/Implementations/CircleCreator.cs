using ShapeSquareCalculator.Shapes;
using ShapeSquareCalculator.Shapes.Implementations;

namespace ShapeSquareCalculator.ShapesCreators.Implementations
{
    public class CircleCreator : ShapeCreator
    {
        private double _radius;

        public CircleCreator(double radius)
        {
            _radius = radius;
        }

        public override Shape CreateShape()
        {
            return new Circle(_radius);
        }
    }
}
