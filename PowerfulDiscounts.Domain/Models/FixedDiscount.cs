namespace PowerfulDiscounts.Model.Models
{
    /// <summary>
    /// Фиксированная скидка.
    /// </summary>
    public class FixedDiscount: IDiscount
    {
        protected FixedDiscount(double sum)
        {
            Sum = sum;
        }
        
        /// <summary>
        /// Сумма скидки.
        /// </summary>
        public double Sum { get; }

        /// <summary>
        /// Создать скидку.
        /// </summary>
        /// <param name="discount">Сумма скидки.</param>
        /// <returns></returns>
        public static FixedDiscount Create(double discount)
        {
            return new FixedDiscount(discount);
        }
        
        /// <summary>
        /// Применить.
        /// </summary>
        /// <param name="actualCost">Стоимость</param>
        /// <returns>Стоимость с учетом скидки.</returns>
        public double CalculateDiscount(double actualCost)
        {
            var finalCost = actualCost - Sum;
            return finalCost > 0 ? finalCost : 0;
        }
    }
}