using System.Collections.Generic;
using PowerfulDiscounts.Model.Discount;

namespace PowerfulDiscounts.Model.Checkout
{
    /// <summary>
    /// Сервис финализации заказа.
    /// </summary>
    public interface ICheckoutService
    {
        /// <summary>
        /// Посчитать скидку.
        /// </summary>
        /// <param name="order">Заказ.</param>
        /// <param name="discounts">Скидки.</param>
        /// <returns></returns>
        double CalculateDiscounts(Order.Order order, IEnumerable<IDiscount> discounts);

        /// <summary>
        /// Сформировать чек.
        /// </summary>
        /// <param name="order">Заказ.</param>
        /// <param name="discounts">Скидки.</param>
        /// <returns></returns>
        Invoice Checkout(Order.Order order, IEnumerable<IDiscount> discounts);
    }
}