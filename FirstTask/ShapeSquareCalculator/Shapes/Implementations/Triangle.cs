namespace ShapeSquareCalculator.Shapes.Implementations
{
    public class Triangle : Shape
    {
        public double A { get; }

        public double B { get; }

        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double CalculateSquare()
        {
            var semiperimeter = GetPerimeter() / 2;

            return Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C));
        }

        private double GetPerimeter()
        {
            return A + B + C;
        }

        public bool IsRight => IsTriangeRight();

        private bool IsTriangeRight()
        {
            double[] sides = { A, B, C };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
