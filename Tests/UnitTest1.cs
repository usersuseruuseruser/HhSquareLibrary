using HhSquareLibrary;
using HhSquareLibrary.Figures;
using HhSquareLibrary.Interfaces;

namespace TestProject1;

public class UnitTest1
{
    private readonly ISquareFinder _figureSquareCalculator = new FigureSquareCalculator();
    
    [Fact]
    public void ShouldFindCorrectRectangleSquare()
    {
        // Arrange
        var rectangle = new Rectangle(3, 4, 5);
        var correctSquare = 6;
        
        // Act
        var calculatedSquare = _figureSquareCalculator.FindSquare(rectangle);
        
        // Assert
        Assert.Equal(correctSquare, calculatedSquare);
    }
    [Fact]
    public void ShouldFindCorrectCircleSquare()
    {
        // Arrange
        var circle = new Circle(5);
        var correctSquare = (float) (Math.PI * Math.Pow(circle.Radius, 2));
        
        // Act
        var calculatedSquare = _figureSquareCalculator.FindSquare(circle);
        
        // Assert
        Assert.Equal(correctSquare, calculatedSquare);
    }
    [Fact]
    public void ShouldThrowArgumentException()
    {
        // Arrange
        var figure = new object();
        
        // Act
        void Act() => _figureSquareCalculator.FindSquare(figure);
        
        // Assert
        Assert.Throws<ArgumentException>(Act);
    }

    [Fact]
    public void ShouldFindCorrectSquareWithRuntimeRectangle()
    {
        // Arrange
        dynamic figure = new Rectangle(3, 4, 5);
        
        // Act
        var calculatedSquare = _figureSquareCalculator.FindSquare(figure);
        
        // Assert
        Assert.Equal(6, calculatedSquare);
    }
    [Fact]
    public void ShouldFindCorrectSquareWithRuntimeCircle()
    {
        // Arrange
        dynamic circle = new Circle( 5);
        var correctSquare = (float)(Math.PI * Math.Pow(circle.Radius, 2));
        // Act
        var calculatedSquare = _figureSquareCalculator.FindSquare(circle);
        
        // Assert
        Assert.Equal(correctSquare, calculatedSquare);
    }
}