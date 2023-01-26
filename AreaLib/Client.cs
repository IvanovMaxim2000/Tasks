
namespace AreaLib
{
    public class Client
    {
        public double GetArea(IFigure figure) => figure.GetArea();

        public double GetCircleArea(double radius)
        {
            var figure = new Circle(radius);
            return figure.GetArea();
        }

        public double GetTriangleArea(double sideA, double sideB, double sideC)
        {
            var figure = new Triangle(sideA, sideB, sideC);
            return figure.GetArea();
        }

        public bool GetIsRightTriangle(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            return triangle.isRightTriangle;
        }
    }
}
