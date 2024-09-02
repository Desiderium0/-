using Xunit;
using Figure;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void GetCircleResult()
        {
            Circle circle = new Circle(10.2);

            var expected = Math.PI * Math.Pow(circle.Radius, 2);
            var actual = circle.CalculaceArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetTriangleResult()
        {
            Triangle triangle = new Triangle(2, 3, 5);

            double num = (triangle.SideA + triangle.SideB + triangle.SideC) / 2.0;
            double expected = Math.Sqrt(num * (num - triangle.SideA) * (num - triangle.SideB) * (num - triangle.SideC));
            var actual = triangle.CalculaceArea();

            Assert.Equal(expected, actual);
        }
    }
}
