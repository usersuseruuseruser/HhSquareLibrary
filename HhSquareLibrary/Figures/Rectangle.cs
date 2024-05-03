using HhSquareLibrary.Figures.@abstract;

namespace HhSquareLibrary.Figures;

public class Rectangle: AbstractRectangleWith3Sides
{
    // это пример треугольника юзера. он может быть с другими полями, но мне главное, чтобы были три стороны
    public Rectangle(float firstSide, float secondSide, float thirdSide) : base(firstSide, secondSide, thirdSide)
    {
    }
}