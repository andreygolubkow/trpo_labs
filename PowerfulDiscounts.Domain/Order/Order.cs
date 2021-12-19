using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using PowerfulDiscounts.Model.Annotations;

namespace PowerfulDiscounts.Model.Order
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private List<OrderItem> _items = new List<OrderItem>();

        /// <summary>
        /// Создать заказ.
        /// </summary>
        /// <param name="user"></param>
        public Order(string user)
        {
            User = user;
        }

        /// <summary>
        /// Автор заказа.
        /// </summary>
        public string User { get; }

        /// <summary>
        /// Предметы в заказе.
        /// </summary>
        public IReadOnlyCollection<OrderItem> Items => _items;

        /// <summary>
        /// Добавить элемент в заказ.
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(OrderItem item)
        {
            if (Items.Any(i => i.Item.Equals(item.Item))) throw new ArgumentException("Такой объект уже есть в заказе");

            _items.Add(item);
            item.PropertyChanged += Item_PropertyChanged;


            OnPropertyChanged(nameof(Items));
        }

        /// <summary>
        /// Удалить элемент из заказа.
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItem(OrderItem item)
        {
            if (Items.All(i => i != item)) throw new ArgumentException("Такого товара нет в заказе");

            item.PropertyChanged += Item_PropertyChanged;
            _items.Remove(item);

            OnPropertyChanged(nameof(Items));
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Items));
        }
    }
}