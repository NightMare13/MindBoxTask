namespace Tests;

public class CircleTests
{
    [Theory]
    [InlineAutoData(-1)]
    [InlineAutoData(0)]
    public void Circle_GetSquare_ShouldThrowException(double radius, Circle circle)
    {
        //  Assert
        circle.Radius = radius;

        //  Act
        var act = () =>
        {
            circle.GetSquare();
        };

        //  Arrange
        Assert.Throws<Exception>(act);
    }

    [Theory]
    [InlineAutoData(5)]
    public void Circle_GetSquare_ShouldBeEqual(double radius, Circle circle)
    {
        //  Assert
        circle.Radius = radius;

        //  Act
        var square = circle.GetSquare();

        //  Arrange
        square.Should().Be(Math.PI * Math.Pow(radius, 2));
    }
}

