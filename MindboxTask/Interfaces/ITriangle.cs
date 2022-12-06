namespace MindboxTask.Interfaces;

/// <summary>
/// Интерфейс для треугольника
/// </summary>
public interface ITriangle : IShape
{
    /// <summary>
    /// Является ли треугольник правильным
    /// </summary>
    /// <returns></returns>
    public bool IsRightTriangle();
}

