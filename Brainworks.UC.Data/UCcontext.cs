using System;
using System.Collections.Generic;
using System.Text;
using Brainworks.UC.Data;
using Microsoft.EntityFrameworkCore;

namespace Brainworks.UC.Data
{
    public class UCcontext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<Service> service { get; set; }
        public DbSet<Vendor> vendor { get; set; }
        public DbSet<Area> area{ get; set; }
        public DbSet<FirstPage> firstPage { get; set; }
        public DbSet<About> about { get; set; }
        public DbSet<Assign> assign { get; set; }
        public DbSet<NewLead> newLead { get; set; }
        public DbSet<Replacement> replcaement { get; set; }
        public DbSet<Complaint> complaint { get; set; }
        public DbSet<ContactUs> contactus { get; set; }
        public DbSet<Feedback> feedback { get; set; }
        public DbSet<Billing> billing { get; set; }
        public DbSet<Due> due { get; set; }


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
           
            modelBuilder.Entity<Service>().Property(b => b.ServiceType).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Service>().Property(b => b.ServiceSubType).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<Service>().Property(b => b.ServicePolicy).HasColumnType("varchar(50)");
            modelBuilder.Entity<Service>().Property(b => b.warranty).HasColumnType("varchar(10)");

            modelBuilder.Entity<Area>().Property(b => b.Pin).HasColumnType("varchar(6)").IsRequired();
            modelBuilder.Entity<Area>().Property(b => b.City).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Area>().Property(b => b.State).HasColumnType("varchar(50)");
            modelBuilder.Entity<Area>().Property(b => b.Subarea).HasColumnType("varchar(50)");

            modelBuilder.Entity<Vendor>().Property(b => b.FirstName).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.ShopName).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Address).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Landmark).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.City).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.State).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Pin).HasColumnType("varchar(6)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Mobile).HasColumnType("varchar(12)").IsRequired();
            modelBuilder.Entity<Vendor>().Property(b => b.Email).HasColumnType("varchar(25)").IsRequired();
            modelBuilder.Entity<Vendor>().HasOne(b => b.service).WithMany(b => b.vendor).HasForeignKey(b => b.ServiceId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Vendor>().HasOne(b => b.area).WithMany(b => b.vendor).HasForeignKey(b => b.AreaId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Vendor>().HasOne(b => b.Customer).WithMany(b => b.vendor).HasForeignKey(b => b.CustomerId).OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<FirstPage>().Property(b => b.Reference).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<FirstPage>().Property(b => b.Key).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<FirstPage>().Property(b => b.Value).HasColumnType("varchar(500 )").IsRequired();

            modelBuilder.Entity<About>().Property(b => b.SatisfactoryCustomer).HasColumnType("varchar(500 )").IsRequired();
            modelBuilder.Entity<About>().Property(b => b.Goal).HasColumnType("varchar(500 )").IsRequired();
            modelBuilder.Entity<About>().Property(b => b.Ahievement).HasColumnType("varchar(500 )").IsRequired();

            modelBuilder.Entity<Assign>().Property(b => b.City).HasColumnType("varchar(100 )").IsRequired();
            modelBuilder.Entity<Assign>().Property(b => b.StatusId).HasColumnType("varchar(100 )").IsRequired();

            modelBuilder.Entity<Assign>().Property(b => b.StatusId).HasColumnType("varchar(100 )").IsRequired();

            modelBuilder.Entity<ContactUs>().Property(b => b.MobileNo).HasColumnType("varchar(12)").IsRequired();
            modelBuilder.Entity<ContactUs>().Property(b => b.Email).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<ContactUs>().Property(b => b.Address).HasColumnType("varchar(100)").IsRequired();

            modelBuilder.Entity<Feedback>().Property(b => b.Comment).HasColumnType("varchar(500)").IsRequired();
            modelBuilder.Entity<Billing>().Property(b => b.ServiceCharge).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Billing>().Property(b => b.MaterialCharge).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Billing>().Property(b => b.Total).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Billing>().Property(b => b.GST).HasColumnType("varchar(20)").IsRequired();

        }
    }
}
 