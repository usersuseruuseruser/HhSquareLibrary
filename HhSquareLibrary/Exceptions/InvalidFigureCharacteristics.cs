namespace HhSquareLibrary.Exceptions;

public class InvalidFigureCharacteristics: Exception
{
    public InvalidFigureCharacteristics(string message = "С такими параметрами невозможно описать фигуру")
        : base(message)
    {
        
    }
}