using COMP003B.SP25.FinalProject.GonzalezA.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP25.FinalProject.GonzalezA.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options) { }

		public DbSet<Customer> Customers { get; set; }
		public DbSet<Car> Cars { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Booking> Bookings { get; set; }
		public DbSet<ServiceType> ServiceTypes { get; set; }
	}
}
