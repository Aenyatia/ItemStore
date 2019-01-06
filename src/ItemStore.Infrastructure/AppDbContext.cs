using ItemStore.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ItemStore.Infrastructure
{
	public class AppDbContext : DbContext
	{
		private readonly IConfiguration _configuration;
		public DbSet<Item> Items { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
			: base(options)
		{
			_configuration = configuration;
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Item>()
				.HasKey(i => i.Id);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ItemStore"));
		}
	}
}
