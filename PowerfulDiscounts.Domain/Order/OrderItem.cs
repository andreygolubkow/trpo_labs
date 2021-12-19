using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PowerfulDiscounts.Model.Order
{
    /// <summary>
    /// Предмет в заказе
    /// </summary>
    public class OrderItem: INotifyPropertyChanged
    {
        private double _count;
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="item">Предмет</param>
        /// <param name="price">Стоимость 1 шт.</param>
        /// <param name="count">Кол-во</param>
        public OrderItem(string item, double price, double count)
        {
            Item = item;
            Price = price;
            _count = count;
        }

        /// <summary>
        /// Предмет заказа.
        /// </summary>
        public string Item { get; }

        /// <summary>
        /// Стоимость 1 единицы.
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// Количество.
        /// </summary>
        public double Count
        {
            get { return _count; }
            private set
            {
                if (value <= 0) throw new ArgumentException("Неверное кол-во товара");

                _count = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Изменить количество товара.
        /// </summary>
        /// <param name="count"></param>
        public void ChangeCount(double count)
        {
            Count = count;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}