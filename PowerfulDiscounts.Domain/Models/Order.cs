using System.Collections.Generic;
namespace PowerfulDiscounts.Model.Models
{
	/// <summary>
	/// Заказ.
	/// </summary>
	public class Order
	{
		public List<IDiscount> Discounts { get; protected set; }

		public decimal GetFinalCost()
		{
			return 0;
		}
	}
}