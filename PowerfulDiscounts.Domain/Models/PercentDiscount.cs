namespace PowerfulDiscounts.Model.Models
{
    /// <summary>
    /// Скидка про проценту от стоимости.
    /// </summary>
    public class PercentDiscount: IDiscount
    {
        private readonly int _discountPercent;

        protected PercentDiscount(int discountPercent)
        {
            _discountPercent = discountPercent;
        }

        /// <summary>
        /// Процент от стоимости.
        /// </summary>
        public int Percent => _discountPercent;

        /// <summary>
        /// Рассчитать скидку.
        /// </summary>
        /// <param name="actualCost">Стоимость заказа.</param>
        /// <returns>Итоговая стоимость заказа.</returns>
        public double CalculateDiscount(double actualCost)
        {
            return actualCost - (actualCost * Percent);
        }

        /// <summary>
        /// Создать экземпляр скидки.
        /// </summary>
        /// <param name="percent">Процент скидки от 1 до 100</param>
        /// <returns>Экземпляр скидки.</returns>
        public static PercentDiscount Create(int percent)
        {
            return new PercentDiscount(percent);
        }
    }
}