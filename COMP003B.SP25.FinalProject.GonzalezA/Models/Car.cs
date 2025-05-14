using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.GonzalezA.Models
{
	public class Car
	{
		public int Id { get; set; }

		[Required]
		public string Make { get; set; }

		[Required]
		public string Model { get; set; }

		[Range(1980, 2100)]
		public int Year { get; set; }

		public string? LicensePlate { get; set; }

		public ICollection<Booking>? Bookings { get; set; }
	}
}
