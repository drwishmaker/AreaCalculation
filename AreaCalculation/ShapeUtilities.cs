namespace AreaCalculation
{
    public static class ShapeUtilities
    {
        public static double GetCircleArea(double radius) 
        {
            return new Circle(radius).CalculateArea();
        }

        public static double GetTriangleAreaBySides(double a, double b, double c) 
        {
            return new Triangle(a, b, c).CalculateArea();
        }
    }
}
