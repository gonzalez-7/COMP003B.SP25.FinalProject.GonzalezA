using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.GonzalezA.Models
{
	public class Customer
	{
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string FullName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Phone]
		public string PhoneNumber { get; set; }

		public ICollection<Booking>? Bookings { get; set; }
	}
}
