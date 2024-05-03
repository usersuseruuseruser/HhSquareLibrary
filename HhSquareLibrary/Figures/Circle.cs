using HhSquareLibrary.Figures.@abstract;

namespace HhSquareLibrary.Figures;

public class Circle: AbstractCircle
{
    // это пример круга юзера. он может быть с другими полями, но мне главное, чтобы был радиус
    public Circle(float radius) : base(radius)
    {
    }
}