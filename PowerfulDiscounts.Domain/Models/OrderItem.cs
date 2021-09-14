using System;
using PowerfulDiscounts.Model.Validation;

namespace PowerfulDiscounts.Model.Models
{
    /// <summary>
    /// Элемент заказа.
    /// </summary>
    public class OrderItem
    {
        protected OrderItem(string name, double price, double amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }
        /// <summary>
        /// Название продукта.
        /// </summary>
        public string Name { get; protected set; }
        
        /// <summary>
        /// Цена за единицу.
        /// </summary>
        public double Price { get; protected set; }
        
        /// <summary>
        /// Количество.
        /// </summary>
        public double Amount { get; protected set; }

        /// <summary>
        /// Создать элемент для заказа.
        /// </summary>
        /// <param name="name">Название позиции</param>
        /// <param name="price">Стоимость за единицу.</param>
        /// <param name="amount">Количество.</param>
        /// <returns>Элемент заказа.</returns>
        public static OrderItem Create(string name, double price, double amount)
        {
            return new OrderItem(name, price, amount);
        }

        /// <summary>
        /// Добавить количество товара.
        /// </summary>
        /// <param name="amount"></param>
        public void Add(double amount)
        {
            Arg.Greater(amount, 0,"Значение должно быть больше 0");
            Amount += amount;
        }

        /// <summary>
        /// Убавить количество товара.
        /// </summary>
        /// <param name="amount"></param>
        public void Remove(double amount)
        {
            Arg.Greater(amount, 0, $"Значение должно быть больше 0 и меньше {Amount}");
            Arg.Less(amount, Amount, $"Значение должно быть больше 0 и меньше {Amount}");
            Amount -= amount;
        }
    }
}