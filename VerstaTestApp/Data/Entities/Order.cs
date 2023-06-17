using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerstaTestApp.Data.Entities
{
	public class Order
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
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
