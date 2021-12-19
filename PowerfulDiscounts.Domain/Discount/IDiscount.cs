namespace PowerfulDiscounts.Model.Discount
{
    /// <summary>
    /// Скидка.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Посчитать скидку.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        double CalculateDiscount(Order.Order order);
    }
}