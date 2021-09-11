using System.Collections.Generic;
using System.Linq;
using PowerfulDiscounts.Model.Services;

namespace PowerfulDiscounts.Model.Models
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Адрес доставки.
        /// </summary>
        public string ShipmentAddress { get;  protected set; }

        /// <summary>
        /// Список заказанных товаров.
        /// </summary>
        public List<OrderItem> Items { get; protected set; } = new List<OrderItem>();

        /// <summary>
        /// Список применяемых скидок.
        /// </summary>
        public List<IDiscount> Discounts { get; protected set; }

        /// <summary>
        /// Расчет финальной стоимости.
        /// </summary>
        /// <returns></returns>
        public double GetFinalCost()
        {
            var lastFinalCost = GetFullCost();
            return Discounts.Aggregate(lastFinalCost, (current, discount) => discount.CalculateDiscount(current));
        }

        /// <summary>
        /// Расчет стоимости без скидок.
        /// </summary>
        /// <returns></returns>
        public double GetFullCost()
        {
            return Items.Sum(i => i.Amount * i.Price);
        }
    }
}