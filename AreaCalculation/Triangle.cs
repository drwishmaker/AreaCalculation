namespace AreaCalculation
{
    public class Triangle : IShape
    {
        private double[] SideLenghts;

        public Triangle(double a, double b, double c) 
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Provided side lengths is not a positive.");

            if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Provided sides do not form a triangle");

            SideLenghts = new double[3] { a, b, c };
        }

        public double CalculateArea() 
        {
            double halfPerimeter = SideLenghts.Sum() / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideLenghts[0]) * (halfPerimeter - SideLenghts[1]) * (halfPerimeter - SideLenghts[2]));
        }

        public bool IsRight() 
        {
            Array.Sort(SideLenghts);

            return (Math.Pow(SideLenghts[0], 2) + Math.Pow(SideLenghts[1], 2) == Math.Pow(SideLenghts[2], 2));
        }
    }
}
