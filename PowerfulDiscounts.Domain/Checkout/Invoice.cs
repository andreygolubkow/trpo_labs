namespace PowerfulDiscounts.Model.Checkout
{
    /// <summary>
    /// Чек о покупке
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text">Текст чека</param>
        /// <param name="user">Пользователь</param>
        /// <param name="finalCost">Стоимость с учетом скидки</param>
        /// <param name="discount">Скидка</param>
        public Invoice(string text, string user, double finalCost, double discount)
        {
            Text = text;
            User = user;
            FinalCost = finalCost;
            TotalCostWithoutDiscount = finalCost + discount;
        }

        /// <summary>
        /// Текст чека.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string User { get; }

        /// <summary>
        /// Общая стоимость.
        /// </summary>
        public double FinalCost { get; }

        /// <summary>
        /// Общая стоимость без скидки.
        /// </summary>
        public double TotalCostWithoutDiscount { get; }
    }
}