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
        private readonly List<IDiscount> _discounts;
        private readonly List<OrderItem> _items;

        protected Order(string shipmentAddress)
        {
            ShipmentAddress = shipmentAddress;
            _items = new List<OrderItem>();
            _discounts = new List<IDiscount>();
        }
        
        /// <summary>
        /// Адрес доставки.
        /// </summary>
        public string ShipmentAddress { get;  protected set; }

        /// <summary>
        /// Список заказанных товаров.
        /// </summary>
        public IReadOnlyCollection<OrderItem> Items => _items;

        /// <summary>
        /// Список применяемых скидок.
        /// </summary>
        public IReadOnlyCollection<IDiscount> Discounts => _discounts;

        
        /// <summary>
        /// Создать заказа.
        /// </summary>
        /// <param name="shipmentAddress">Адрес доставки.</param>
        /// <returns>Заказ.</returns>
        public static Order Create(string shipmentAddress)
        {
            return new Order(shipmentAddress);
        }
        
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

        /// <summary>
        /// Добавить элемент заказа.
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(OrderItem item)
        {
            _items.Add(item);
        }

        /// <summary>
        /// Удалить элемент заказа.
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItem(OrderItem item)
        {
            _items.Remove(item);
        }

        /// <summary>
        /// Изменить адрес доставки.
        /// </summary>
        /// <param name="newAddress">Новый адрес доставки.</param>
        public void ChangeAddress(string newAddress)
        {
            ShipmentAddress = newAddress;
        }

        /// <summary>
        /// Добавить скидку.
        /// </summary>
        /// <param name="discount">Скидка.</param>
        public void AddDiscount(IDiscount discount)
        {
            _discounts.Add(discount);
        }

        /// <summary>
        /// Удалить скидку.
        /// </summary>
        /// <param name="discount">Скидка.</param>
        public void RemoveDiscount(IDiscount discount)
        {
            _discounts.Remove(discount);
        }
    }
    
}