using System.ComponentModel.DataAnnotations;
using MindboxTask.Interfaces;

namespace MindboxTask.Shapes;

public class Triangle : ITriangle
{
    public double SideA { get; set; }

    public double SideB { get; set; }

    public double SideC { get; set; }

    #region ITriangle implementation

    public double GetSquare()
    {
        Validate();

        var halfPerimeter = GetPerimeter() / 2;

        var square = Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));

        return square;
    }

    public bool IsRightTriangle()
    {
        return (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2)
                || Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2)
                || Math.Pow(SideC, 2) + Math.Pow(SideB, 2) == Math.Pow(SideA, 2));
    }

    #endregion

    #region Private Methods

    private double GetPerimeter()
    {
        return SideA + SideB + SideC;
    }

    private void Validate()
    {
        if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            throw new Exception("Сторона не может быть меньше или равна 0");

        if (!IsTriangleExists())
            throw new Exception("Такого треугольника не существует");
    }

    private bool IsTriangleExists()
    {
        return (   SideA + SideB > SideC
                && SideA + SideC > SideB
                && SideB + SideC > SideA
                );
    }

    #endregion
}

