namespace AreaCalculation
{
    public class Circle : IShape
    {
        private double Radius;

        public Circle(double radius) 
        {
            if (radius <= 0)
                throw new ArgumentException("Provided radius is not positive.");

            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
