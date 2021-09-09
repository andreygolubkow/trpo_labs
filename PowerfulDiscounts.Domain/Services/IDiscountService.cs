using PowerfulDiscounts.Model.Models;
namespace PowerfulDiscounts.Model.Services
{
	/// <summary>
	/// Алгоритм начисления скидки.
	/// </summary>
	public interface IDiscountService
	{
		/// <summary>
		/// Применить скидку.
		/// </summary>
		/// <param name="order"></param>
		void ApplyDiscount(Order order);
	}
}