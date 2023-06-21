using System.ComponentModel.DataAnnotations;

namespace VerstaTestApp.Models
{
	/// <summary>
	/// Модель заказа, используемая для создания нового заказа.
	/// </summary>
	public class CreateOrderModel
	{
		/// <summary>
		/// Город отправителя.
		/// </summary>
		[Required]
		public string SenderCity { get; set; }
		/// <summary>
		/// Адрес отправителя
		/// </summary>
		[Required]
		public string SenderAddress { get; set; }
		/// <summary>
		/// Город получателя
		/// </summary>
		[Required]
		public string RecipientCity { get; set; }
		/// <summary>
		/// Адрес получателя
		/// </summary>
		[Required]
		public string RecipientAddress { get; set; }
		/// <summary>
		/// Вес груза
		/// </summary>
		[Required]
		public double Weight { get; set; }
		/// <summary>
		/// Дата забора груза
		/// </summary>
		[Required]
		public DateTimeOffset TakeDate { get; set; }
	}
}
