using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Brainworks.UC.Data
{
    public class UCcontext:DbContext
    {
        public DbSet<Customer> customer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = "Server=DESKTOP-6N1BUO9;Initial Catalog=UCData;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionstring);
        }
        //data modeling 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(b => b.FirstName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.LastName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Address).HasColumnType("varchar(500)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Landmark).HasColumnType("varchar(500)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.City).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.State).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Pin).HasColumnType("varchar(6)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Mobile).HasColumnType("varchar(12)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Email).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Customer>().Property(b => b.Service).HasColumnType("varchar(100)").IsRequired();

        }
    }
}
 