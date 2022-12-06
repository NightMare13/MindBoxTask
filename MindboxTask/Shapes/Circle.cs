using MindboxTask.Interfaces;

namespace MindboxTask.Shapes;

public class Circle : IShape
{
    public double Radius { get; set; }

    #region IShape implementation

    public double GetSquare()
    {
        if (Radius <= 0)
            throw new Exception("Радиус не может быть меньше либо равен 0");

        return Math.PI * Math.Pow(Radius, 2);
    }

    #endregion

}

