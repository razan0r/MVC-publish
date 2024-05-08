using crud_app1.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_app1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=db4783.public.databaseasp.net; Database=db4783; User Id=db4783; Password=Pm9+?Ba4Cf6=; Encrypt=False; MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Mathematics", Description = "The study of numbers, quantity, structure, and change." },
                new Department { Id = 2, Name = "Computer Science", Description = "The study of computation, algorithms, data structures, and programming." },
                new Department { Id = 3, Name = "Physics", Description = "The study of matter, energy, space, and time." }
            );
        }
    }
}
