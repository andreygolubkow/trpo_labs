namespace PowerfulDiscounts.Model.Models
{
	public interface IDiscount
	{
		/// <summary>
		/// Посчитать скидку.
		/// </summary>
		/// <param name="actualCost">Стоимость заказа</param>
		/// <returns></returns>
		public double CalculateDiscount(double actualCost);
	}
}