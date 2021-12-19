using System;

namespace PowerfulDiscounts.Model.Discount
{
    public class ByPercentDiscount: IDiscount
    {
        private double _percent;

        public ByPercentDiscount(double percent)
        {
            if (percent<=0 || percent>= 100) throw new ArgumentException("Укажите процент скидки в интервале (0;100)");
            _percent = percent;
        }

        public double CalculateDiscount(Order.Order order)
        {
            return order.GetTotalCost() * (0.01 * _percent);
        }
    }
}