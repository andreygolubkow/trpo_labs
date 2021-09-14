using System;

namespace PowerfulDiscounts.Model.Exceptions
{
    public class InvalidOperationException: Exception
    {
        public InvalidOperationException(string message = "Данная операция недопустима"): base(message)
        {
        }
    }
}