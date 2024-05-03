using HhSquareLibrary.Exceptions;

namespace HhSquareLibrary.Figures.@abstract;

public abstract class AbstractRectangleWith3Sides
{
    public float FirstSide { get; set; }
    public float SecondSide { get; set; }
    public float ThirdSide { get; set; }

    public AbstractRectangleWith3Sides(float firstSide, float secondSide, float thirdSide)
    {
        if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide ||
            secondSide + thirdSide <= firstSide)
        {
            throw new InvalidFigureCharacteristics("Не выполнено неравенство треугольника");
        }

        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new InvalidFigureCharacteristics("Одна из сторон не положительная, не может быть треугольником");
        }
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }
    
}