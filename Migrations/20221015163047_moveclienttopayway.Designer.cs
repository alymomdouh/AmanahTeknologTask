﻿// <auto-generated />
using System;
using AmanahTeknologTask.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AmanahTeknologTask.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221015163047_moveclienttopayway")]
    partial class moveclienttopayway
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.BankInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyClientId")
                        .HasColumnType("int");

                    b.Property<int?>("IndividualClientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BankInformation");
                });

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.CardInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CVC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyClientId")
                        .HasColumnType("int");

                    b.Property<int?>("IndividualClientId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("expireDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CardInformation");
                });

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.CompanyClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyClients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "CompanyClient1@gmail.com",
                            Name = "CompanyClient1"
                        });
                });

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.IndividualClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IndividualClients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "IndividualClient1@gmail.com",
                            Name = "IndividualClient1"
                        });
                });

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyClientId")
                        .HasColumnType("int");

                    b.Property<int?>("IndividualClientId")
                        .HasColumnType("int");

                    b.Property<int>("PaywayId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("TaxId")
                        .HasColumnType("int");

                    b.Property<decimal>("Totalprice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyClientId");

                    b.HasIndex("IndividualClientId");

                    b.HasIndex("PaywayId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TaxId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.Payway", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BankInformationId")
                        .HasColumnType("int");

                    b.Property<int?>("CardInformationId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyClientId")
                        .HasColumnType("int");

                    b.Property<int?>("IndividualClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BankInformationId");

                    b.HasIndex("CardInformationId");

                    b.HasIndex("CompanyClientId");

                    b.HasIndex("IndividualClientId");

                    b.ToTable("Payway");
                });

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Product1",
                            Price = 10
                        },
                        new
                        {
                            Id = 2,
                            Name = "Product2",
                            Price = 20
                        },
                        new
                        {
                            Id = 3,
                            Name = "Product3",
                            Price = 30
                        },
                        new
                        {
                            Id = 4,
                            Name = "Product4",
                            Price = 40
                        },
                        new
                        {
                            Id = 5,
                            Name = "Product5",
                            Price = 50
                        },
                        new
                        {
                            Id = 6,
                            Name = "Product6",
                            Price = 60
                        });
                });

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.Tax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Taxes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "John Doe",
                            Value = 30m
                        });
                });

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.Invoice", b =>
                {
                    b.HasOne("AmanahTeknologTask.Domains.Models.CompanyClient", "CompanyClient")
                        .WithMany()
                        .HasForeignKey("CompanyClientId");

                    b.HasOne("AmanahTeknologTask.Domains.Models.IndividualClient", "IndividualClient")
                        .WithMany()
                        .HasForeignKey("IndividualClientId");

                    b.HasOne("AmanahTeknologTask.Domains.Models.Payway", "Payway")
                        .WithMany()
                        .HasForeignKey("PaywayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AmanahTeknologTask.Domains.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AmanahTeknologTask.Domains.Models.Tax", "Tax")
                        .WithMany()
                        .HasForeignKey("TaxId");

                    b.Navigation("CompanyClient");

                    b.Navigation("IndividualClient");

                    b.Navigation("Payway");

                    b.Navigation("product");

                    b.Navigation("Tax");
                });

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.Payway", b =>
                {
                    b.HasOne("AmanahTeknologTask.Domains.Models.BankInformation", "BankInformation")
                        .WithMany()
                        .HasForeignKey("BankInformationId");

                    b.HasOne("AmanahTeknologTask.Domains.Models.CardInformation", "CardInformation")
                        .WithMany()
                        .HasForeignKey("CardInformationId");

                    b.HasOne("AmanahTeknologTask.Domains.Models.CompanyClient", null)
                        .WithMany("Payway")
                        .HasForeignKey("CompanyClientId");

                    b.HasOne("AmanahTeknologTask.Domains.Models.IndividualClient", null)
                        .WithMany("Payway")
                        .HasForeignKey("IndividualClientId");

                    b.Navigation("BankInformation");

                    b.Navigation("CardInformation");
                });

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.CompanyClient", b =>
                {
                    b.Navigation("Payway");
                });

            modelBuilder.Entity("AmanahTeknologTask.Domains.Models.IndividualClient", b =>
                {
                    b.Navigation("Payway");
                });
#pragma warning restore 612, 618
        }
    }
}
