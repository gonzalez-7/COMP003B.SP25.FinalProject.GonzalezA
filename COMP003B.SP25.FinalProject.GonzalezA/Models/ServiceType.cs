using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.FinalProject.GonzalezA.Models
{
	public class ServiceType
	{
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[StringLength(200)]
		public string? Description { get; set; }

		[Range(0, 10000)]
		public decimal Price { get; set; }

		public ICollection<Service>? Services { get; set; }
	}
}
