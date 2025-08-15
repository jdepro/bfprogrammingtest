using Microsoft.EntityFrameworkCore;
using blackfinch_test.DataStore.Entities;

namespace blackfinch_test.DataStore;

public partial class TempStorage : DbContext
{
	public DbSet<Application> Applications { get; set; }
	public DbSet<Decision> Decisions { get; set; }
	public DbSet<User> Users { get; set; }

	protected override void OnConfiguring(
		DbContextOptionsBuilder optionsBuilder
	)
	{
		base.OnConfiguring(optionsBuilder);
	}

	public TempStorage() { }

	public TempStorage(DbContextOptions<TempStorage> options) : base(options)
	{
		Database.EnsureCreated();
	}

	// Seed initial data using OnModelCreating
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Application>().HasKey(a => a.Id);
		modelBuilder.Entity<Decision>().HasKey(d => d.ApplicationId);
		modelBuilder.Entity<User>().HasKey(u => u.Id);

		modelBuilder.InitialDataSeed();
	}
}
