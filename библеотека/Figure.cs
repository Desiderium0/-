namespace Figure
{
    public interface IFigure
    {
        double CalculaceArea();
    }

    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculaceArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public double CalculaceArea()
        {
            double x = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(x * (x - SideA) * (x - SideB) * (x - SideC));
        }
    }
}

//Привет кто проверяет код :)
