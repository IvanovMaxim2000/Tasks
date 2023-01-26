
namespace AreaLib
{
    public interface IClient
    {
        double GetArea(IFigure figure);
        double GetCircleArea(double radius);
        double GetTriangleArea(double sideA, double sideB, double sideC);
        bool GetIsRightTriangle(double sideA, double sideB, double sideC);
    }
}
