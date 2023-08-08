using ShapeSquareCalculator.Shapes;
using ShapeSquareCalculator.Shapes.Implementations;

namespace ShapeSquareCalculator.ShapesCreators.Implementations
{
    public class TriangleCreator : ShapeCreator
    {
        private double A;
        private double B;
        private double C;


        public TriangleCreator(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override Shape CreateShape()
        {
            return new Triangle(A, B, C);
        }
    }
}
