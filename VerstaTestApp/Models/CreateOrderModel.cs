using System.ComponentModel.DataAnnotations;

namespace VerstaTestApp.Models
{
	public class CreateOrderModel
	{
		[Required]
		public string SenderCity { get; set; }
		[Required]
		public string SenderAddress { get; set; }
		[Required]
		public string RecipientCity { get; set; }
		[Required]
		public string RecipientAddress { get; set; }
		[Required]
		public double Weight { get; set; }
		[Required]
		public DateTimeOffset TakeDate { get; set; }
	}
}
