using System.Drawing;
using HhSquareLibrary.Figures.@abstract;
using HhSquareLibrary.Interfaces;

namespace HhSquareLibrary;

public class FigureSquareCalculator: ISquareFinder,
    ISquareFinder<AbstractRectangleWith3Sides>,
    ISquareFinder<AbstractCircle>
{
    public float FindSquare<T>(T figure)
    {
        return figure switch
        {
            AbstractRectangleWith3Sides abstractRectangleWith3Sides => FindSquare(abstractRectangleWith3Sides),
            AbstractCircle abstractCircle => FindSquare(abstractCircle),
            _ => throw new ArgumentException("Неизвестный тип фигуры")
        };
    }

    public float FindSquare(AbstractRectangleWith3Sides abstractRectangleWith3Sides)
    {
        var firstSide = abstractRectangleWith3Sides.FirstSide;
        var secondSide = abstractRectangleWith3Sides.SecondSide;
        var thirdSide = abstractRectangleWith3Sides.ThirdSide;
        // проверка на прямоугольность
        var maxSide = Math.Max(firstSide, Math.Max(secondSide, thirdSide));
        var minSide = Math.Min(firstSide, Math.Min(secondSide, thirdSide));
        var middleSide = firstSide + secondSide + thirdSide - maxSide - minSide;
        if ((minSide * minSide + middleSide * middleSide).Equals(maxSide * maxSide))
        {
            return middleSide * minSide / 2;
        }
        
        // общий случай
        var halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
        return (float) Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide)
                                 * (halfPerimeter - thirdSide));
    }

    public float FindSquare(AbstractCircle abstractCircle)
    {
        return (float) (Math.PI * Math.Pow(abstractCircle.Radius, 2));
    }
}