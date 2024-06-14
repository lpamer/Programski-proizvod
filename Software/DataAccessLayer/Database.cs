using EntitiesLayer.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Support> Supports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Supports)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Supports)
                .WithOptional(e => e.Employee1)
                .HasForeignKey(e => e.employee);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.totalCost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Vehicle>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Vehicle)
                .WillCascadeOnDelete(false);

        }
    }
}
