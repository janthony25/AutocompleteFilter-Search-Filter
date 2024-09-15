using AutocompleteFilter.Models;
using Microsoft.EntityFrameworkCore;

namespace AutocompleteFilter.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>()
                .HasMany(car => car.CarModel)
                .WithOne(cm => cm.Car)
                .HasForeignKey(cm => cm.CarId);
        }
    }
}
