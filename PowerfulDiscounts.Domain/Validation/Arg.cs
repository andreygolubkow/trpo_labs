using System;
using PowerfulDiscounts.Model.Exceptions;

namespace PowerfulDiscounts.Model.Validation
{
    /// <summary>
    /// Набор методов для валидации значений.
    /// </summary>
    public static class Arg
    {
        /// <summary>
        /// Объект А больше объекта Б.
        /// </summary>
        /// <param name="arg">Объект А</param>
        /// <param name="val">Объект Б</param>
        /// <param name="error">Текст ошибки</param>
        /// <typeparam name="T"></typeparam>
        /// <exception cref="IncorrectDataException">Если меньше или равно.</exception>
        public static void Greater<T>(IComparable<T> arg, T val, string error = "Значение должно быть больше")
        {
            if (arg.CompareTo(val)  > 0) return;
            throw new IncorrectDataException(error);
        }

        /// <summary>
        /// Объект А должен быть меньше Объекта Б.
        /// </summary>
        /// <param name="arg">Объект А.</param>
        /// <param name="val">Объект Б.</param>
        /// <param name="error">Текст ошибки</param>
        /// <typeparam name="T"></typeparam>
        /// <exception cref="IncorrectDataException">Если А больше или равно Б</exception>
        public static void Less<T>(IComparable<T> arg, T val, string error = "Значение должно быть меньше")
        {
            if (arg.CompareTo(val) < 0) return;
            throw new IncorrectDataException(error);
        }

        public static void NotEmpty(string val, string error = "Строка должна быть не пустой")
        {
            if (!string.IsNullOrWhiteSpace(val)) return;
            throw new IncorrectDataException(error);
        }
    }
}