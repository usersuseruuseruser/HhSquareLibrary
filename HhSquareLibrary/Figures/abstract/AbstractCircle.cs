using HhSquareLibrary.Exceptions;

namespace HhSquareLibrary.Figures.@abstract;

public abstract class AbstractCircle
{
    public float Radius { get; set; }

    public AbstractCircle(float radius)
    {
        if (radius < 0)
        {
            throw new InvalidFigureCharacteristics("Радиус не может быть отрицательным");
        }
        Radius = radius;
    }
}