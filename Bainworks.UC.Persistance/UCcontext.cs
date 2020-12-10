using System;
using System.Collections.Generic;
using System.Text;
using Brainworks.UC.Data;
using Microsoft.EntityFrameworkCore;

namespace Brainworks.UC.Persistance
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
        public DbSet<Replacement> replacement { get; set; }
        public DbSet<Completed> completed { get; set; }
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

            modelBuilder.Entity<Completed>().HasOne(b => b.service).WithMany(b => b.completed).HasForeignKey(b => b.ServiceId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Completed>().HasOne(b => b.customer).WithMany(b => b.completed).HasForeignKey(b => b.CustomerId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Completed>().HasOne(b => b.customer).WithMany(b => b.completed).HasForeignKey(b => b.CityId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Completed>().HasOne(b => b.customer).WithMany(b => b.completed).HasForeignKey(b => b.CustPinId).OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Vendor>().HasOne(b => b.service).WithMany(b => b.vendor).HasForeignKey(b => b.ServiceId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Vendor>().HasOne(b => b.area).WithMany(b => b.vendor).HasForeignKey(b => b.AreaId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Vendor>().HasOne(b => b.Customer).WithMany(b => b.vendor).HasForeignKey(b => b.CustomerId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Assign>().HasOne(b => b.service).WithMany(b => b.assign).HasForeignKey(b => b.ServiceId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Due>().HasOne(b => b.billing).WithMany(b => b.due).HasForeignKey(b => b.ServiceChargeId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Due>().HasOne(b => b.billing).WithMany(b => b.due).HasForeignKey(b => b.MaterialChargeId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Due>().HasOne(b => b.billing).WithMany(b => b.due).HasForeignKey(b => b.TotalId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<NewLead>().HasOne(b => b.customer).WithMany(b => b.newLead).HasForeignKey(b => b.CustomerId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<NewLead>().HasOne(b => b.customer).WithMany(b => b.newLead).HasForeignKey(b => b.CityId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<NewLead>().HasOne(b => b.customer).WithMany(b => b.newLead).HasForeignKey(b => b.CustPinId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Replacement>().HasOne(b => b.customer).WithMany(b => b.replacement).HasForeignKey(b => b.CustomerId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Replacement>().HasOne(b => b.customer).WithMany(b => b.replacement).HasForeignKey(b => b.CityId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Replacement>().HasOne(b => b.assign).WithMany(b => b.replacement).HasForeignKey(b => b.StatusId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Complaint>().HasOne(b => b.assign).WithMany(b => b.complaint).HasForeignKey(b => b.CustomerId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Complaint>().HasOne(b => b.customer).WithMany(b => b.complaint).HasForeignKey(b => b.CityId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Complaint>().HasOne(b => b.assign).WithMany(b => b.complaint).HasForeignKey(b => b.StatusId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
 