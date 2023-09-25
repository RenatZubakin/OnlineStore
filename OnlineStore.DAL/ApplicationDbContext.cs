using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DAL
{

    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new { Id = 1, Name = "Tomato", Description = "Твалпалп аллалал", Quantity=5, Price=100m, CreatedDate= DateTime.UtcNow }
        );
        }
        public DbSet<Product> Products { get; set; }
    }
}
