using HhSquareLibrary;
using HhSquareLibrary.Figures;
using HhSquareLibrary.Figures.@abstract;

var squareCalculator = new FigureSquareCalculator();
object react = new Rectangle(3, 4, 5);
object circle = new Circle(5);
Console.WriteLine(squareCalculator.FindSquare(react));
Console.WriteLine(squareCalculator.FindSquare(circle));