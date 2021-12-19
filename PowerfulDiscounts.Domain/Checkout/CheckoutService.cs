using System.Collections.Generic;
using PowerfulDiscounts.Model.Discount;

namespace PowerfulDiscounts.Model.Checkout
{
    public class CheckoutService:ICheckoutService
    {
        public double CalculateDiscounts(Order.Order order, IEnumerable<IDiscount> discounts)
        {
            throw new System.NotImplementedException();
        }

        public Invoice Checkout(Order.Order order, IEnumerable<IDiscount> discounts)
        {
            throw new System.NotImplementedException();
        }
    }
}