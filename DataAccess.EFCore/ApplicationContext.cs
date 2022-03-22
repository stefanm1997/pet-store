using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
        }
        public DbSet<PetToy> PetToys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPetToy> OrderPetToy { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderPetToy>().HasKey(sc => new { sc.OrdersId, sc.PetToysId });

            modelBuilder.Entity<OrderPetToy>()
            .HasOne<PetToy>(sc => sc.PetToys)
            .WithMany(s => s.Orders)
            .HasForeignKey(sc => sc.PetToysId);

            modelBuilder.Entity<OrderPetToy>()
                .HasOne<Order>(sc => sc.Order)
                .WithMany(s => s.PetToys)
                .HasForeignKey(sc => sc.OrdersId);
        }
    }
}
