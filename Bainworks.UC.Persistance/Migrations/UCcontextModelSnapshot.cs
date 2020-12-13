﻿// <auto-generated />
using System;
using Brainworks.UC.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Brainworks.UC.Persistance.Migrations
{
    [DbContext(typeof(UCcontext))]
    partial class UCcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Brainworks.UC.Data.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ahievement")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Goal")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("SatisfactoryCustomer")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

                    b.ToTable("about");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Pin")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Subarea")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("area");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Assign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PinId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ServiceId");

                    b.ToTable("assign");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Billing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GST")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MaterialCharge")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ServiceCharge")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Total")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("billing");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Complaint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("StatusId");

                    b.ToTable("complaint");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Completed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CustPinId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("assignId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustPinId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("assignId");

                    b.ToTable("completed");
                });

            modelBuilder.Entity("Brainworks.UC.Data.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.HasKey("Id");

                    b.ToTable("contactus");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Landmark")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Pin")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("ServiceId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Due", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaterialChargeId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceChargeId")
                        .HasColumnType("int");

                    b.Property<int>("TotalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TotalId");

                    b.ToTable("due");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("VendorId");

                    b.ToTable("feedback");
                });

            modelBuilder.Entity("Brainworks.UC.Data.FirstPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

                    b.ToTable("firstPage");
                });

            modelBuilder.Entity("Brainworks.UC.Data.NewLead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustPinId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("assignId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustPinId");

                    b.HasIndex("assignId");

                    b.ToTable("newLead");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Replacement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("StatusId");

                    b.ToTable("replacement");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServicePolicy")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ServiceSubType")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("warranty")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("service");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Vendor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Landmark")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Pin")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("ShopName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("AreaId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ServiceId");

                    b.ToTable("vendor");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Assign", b =>
                {
                    b.HasOne("Brainworks.UC.Data.Customer", "customer")
                        .WithMany("assign")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Brainworks.UC.Data.Service", "service")
                        .WithMany("assign")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Brainworks.UC.Data.Complaint", b =>
                {
                    b.HasOne("Brainworks.UC.Data.Customer", "customer")
                        .WithMany("complaint")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Brainworks.UC.Data.Assign", "assign")
                        .WithMany("complaint")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Brainworks.UC.Data.Completed", b =>
                {
                    b.HasOne("Brainworks.UC.Data.Customer", "customer")
                        .WithMany("completed")
                        .HasForeignKey("CustPinId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Brainworks.UC.Data.Service", "service")
                        .WithMany("completed")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Brainworks.UC.Data.Assign", "assign")
                        .WithMany("comleted")
                        .HasForeignKey("assignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Brainworks.UC.Data.Customer", b =>
                {
                    b.HasOne("Brainworks.UC.Data.Area", "area")
                        .WithMany("customer")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Brainworks.UC.Data.Service", "service")
                        .WithMany("customer")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Brainworks.UC.Data.Due", b =>
                {
                    b.HasOne("Brainworks.UC.Data.Billing", "billing")
                        .WithMany("due")
                        .HasForeignKey("TotalId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Brainworks.UC.Data.Feedback", b =>
                {
                    b.HasOne("Brainworks.UC.Data.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Brainworks.UC.Data.Vendor", "vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Brainworks.UC.Data.NewLead", b =>
                {
                    b.HasOne("Brainworks.UC.Data.Customer", "customer")
                        .WithMany("newLead")
                        .HasForeignKey("CustPinId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Brainworks.UC.Data.Assign", "assign")
                        .WithMany("newlead")
                        .HasForeignKey("assignId");
                });

            modelBuilder.Entity("Brainworks.UC.Data.Replacement", b =>
                {
                    b.HasOne("Brainworks.UC.Data.Customer", "customer")
                        .WithMany("replacement")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Brainworks.UC.Data.Assign", "assign")
                        .WithMany("replacement")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Brainworks.UC.Data.Vendor", b =>
                {
                    b.HasOne("Brainworks.UC.Data.Area", "area")
                        .WithMany("vendor")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Brainworks.UC.Data.Customer", "Customer")
                        .WithMany("vendor")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Brainworks.UC.Data.Service", "service")
                        .WithMany("vendor")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
