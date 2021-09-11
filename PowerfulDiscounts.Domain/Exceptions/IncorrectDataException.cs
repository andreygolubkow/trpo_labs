using System;

namespace PowerfulDiscounts.Model.Exceptions
{
    /// <summary>
    /// Исключение выбрасывается, если введены некорректные данные.
    /// </summary>
    public class IncorrectDataException: Exception
    {
        public IncorrectDataException(string message = ""):base(message)
        {
        }
    }
}