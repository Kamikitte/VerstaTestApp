namespace VerstaTestApp.Models
{
	/// <summary>
	/// Модель заказа, используемая для передачи информации о заказе к клиентскому приложению.
	/// </summary>
	public class OrderDTO
	{
		/// <summary>
		/// Идентификатор заказа
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Город отправителя.
		/// </summary>
		public string SenderCity { get; set; }
		/// <summary>
		/// Адрес отправителя
		/// </summary>
		public string SenderAddress { get; set; }
		/// <summary>
		/// Город получателя
		/// </summary>		[Required]
		public string RecipientCity { get; set; }
		/// <summary>
		/// Адрес получателя
		/// </summary>
		public string RecipientAddress { get; set; }
		/// <summary>
		/// Вес груза
		/// </summary>
		public double Weight { get; set; }
		/// <summary>
		/// Дата забора груза
		/// </summary>
		public DateTimeOffset TakeDate { get; set; }
	}
}
