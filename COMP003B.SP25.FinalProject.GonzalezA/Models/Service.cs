using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.GonzalezA.Models
{
	public class Service
	{
		public int Id { get; set; }

		[Required]
		public DateTime DateProvided { get; set; }

		[Required]
		public int ServiceTypeId { get; set; }
		public ServiceType? ServiceType { get; set; }

		public ICollection<Booking>? Bookings { get; set; }
	}
}
