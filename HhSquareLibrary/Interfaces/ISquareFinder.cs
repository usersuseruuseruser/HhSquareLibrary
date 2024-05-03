namespace HhSquareLibrary.Interfaces;

public interface ISquareFinder
{
    float FindSquare<T>(T figure);
}

public interface ISquareFinder<T>
{
    float  FindSquare(T rectangle);
}