namespace ShapeSquareCalculator.Shapes.Implementations
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) 
        {
            Radius = radius;
        }

        public override double CalculateSquare()
        {
            return Math.PI * Math.Pow(Radius, 2) / 2;
        }
    }
}
