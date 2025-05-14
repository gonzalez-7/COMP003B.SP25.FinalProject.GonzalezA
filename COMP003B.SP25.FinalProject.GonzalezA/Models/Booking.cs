using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.GonzalezA.Models
{
	public class Booking
	{
		public int Id { get; set; }

		[Required]
		public DateTime BookingDate { get; set; }

		public int CustomerId { get; set; }
		public Customer? Customer { get; set; }

		public int CarId { get; set; }
		public Car? Car { get; set; }

		public int ServiceId { get; set; }
		public Service? Service { get; set; }

		[StringLength(300)]
		public string? Notes { get; set; }
	}
}
