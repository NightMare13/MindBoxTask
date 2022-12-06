using MindboxTask.Shapes;

namespace Tests;

public class TriangleTests
{
    [Theory]
    [InlineAutoData(4, 4, 10)]
    [InlineAutoData(4, 4, 0)]
    [InlineAutoData(4, 4, -1)]
    public void Triangle_GetSquare_ShouldThrowException(double sideA, double sideB, double sideC, Triangle triangle)
    {
        //  Assert
        triangle.SideA = sideA;
        triangle.SideB = sideB;
        triangle.SideC = sideC;

        //  Act
        var act = () =>
        {
            triangle.GetSquare();
        };

        //  Arrange
        Assert.Throws<Exception>(act);
    }


    [Theory]
    [InlineAutoData(3,4,5)]
    public void Triangle_GetSquare_ShouldBeEqual(double sideA, double sideB, double sideC, Triangle triangle)
    {
        //  Assert
        triangle.SideA = sideA;
        triangle.SideB = sideB;
        triangle.SideC = sideC;

        //  Act
        var square = triangle.GetSquare();

        //  Arrange
        square.Should().Be(6);
    }

    [Theory]
    [InlineAutoData(3, 4, 5)]
    public void Triangle_IsRightTriangle_ShouldBeTrue(double sideA, double sideB, double sideC, Triangle triangle)
    {
        //  Assert
        triangle.SideA = sideA;
        triangle.SideB = sideB;
        triangle.SideC = sideC;

        //  Act
        var result = triangle.IsRightTriangle();

        //  Arrange
        result.Should().Be(true);
    }

    [Theory]
    [InlineAutoData(3, 5, 5)]
    public void Triangle_IsRightTriangle_ShouldBeFalse(double sideA, double sideB, double sideC, Triangle triangle)
    {
        //  Assert
        triangle.SideA = sideA;
        triangle.SideB = sideB;
        triangle.SideC = sideC;

        //  Act
        var result = triangle.IsRightTriangle();

        //  Arrange
        result.Should().Be(false);
    }
}

