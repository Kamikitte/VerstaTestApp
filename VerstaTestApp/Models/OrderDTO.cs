using System.ComponentModel.DataAnnotations;

namespace VerstaTestApp.Models
{
	public class OrderDTO
	{
		public int Id { get; set; }
		public string SenderCity { get; set; }
		public string SenderAddress { get; set; }
		public string RecipientCity { get; set; }
		public string RecipientAddress { get; set; }
		public double Weight { get; set; }
		public DateTimeOffset TakeDate { get; set; }
	}
}
