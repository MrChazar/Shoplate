﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoplateAPP.Data;

#nullable disable

namespace ShoplateAPP.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230605180906_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShoplateAPP.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Wysokiej jakości aparat cyfrowy do rejestrowania niesamowitych zdjęć i filmów.",
                            Image = "kamera.jpg",
                            Name = "Kamera",
                            Price = 499.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Telewizor Ultra HD z żywym wyświetlaczem i inteligentnymi funkcjami.",
                            Image = "telewizor_4k.jpg",
                            Name = "Telewizor 4K",
                            Price = 999.99m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Potężny laptop z szybkim procesorem i dużą ilością miejsca na dane, idealny do pracy.",
                            Image = "laptop.jpg",
                            Name = "Laptop",
                            Price = 899.99m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Konsola do gier zapewniająca wciągające doznania podczas grania.",
                            Image = "konsola_do_gier.jpg",
                            Name = "Konsola do gier",
                            Price = 399.99m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Smartfon z bogatymi funkcjami, wysoką rozdzielczością aparatu i długim czasem pracy baterii.",
                            Image = "smartfon.jpg",
                            Name = "Smartfon",
                            Price = 699.99m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Uniwersalny tablet do pracy i rozrywki w podróży.",
                            Image = "tablet.jpg",
                            Name = "Tablet",
                            Price = 299.99m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Klawiatura mechaniczna zapewniająca taktylne doświadczenia podczas pisania.",
                            Image = "klawiatura_mechaniczna.jpg",
                            Name = "Klawiatura mechaniczna",
                            Price = 149.99m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Mysz gamingowa z możliwością personalizacji przycisków i wysokim DPI.",
                            Image = "mysz_gamingowa.jpg",
                            Name = "Mysz gamingowa",
                            Price = 79.99m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Monitor o wysokiej rozdzielczości dla wyraźnych obrazów i płynnej pracy.",
                            Image = "monitor.jpg",
                            Name = "Monitor",
                            Price = 299.99m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Głośniki do komputera zapewniające immersyjne brzmienie podczas gier i multimediów.",
                            Image = "glosniki_komputerowe.jpg",
                            Name = "Głośniki komputerowe",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = 11,
                            Description = "Słuchawki gamingowe z dźwiękiem przestrzennym i redukcją hałasu.",
                            Image = "sluchawki_gamingowe.jpg",
                            Name = "Słuchawki gamingowe",
                            Price = 149.99m
                        },
                        new
                        {
                            Id = 12,
                            Description = "Mikrofon USB do profesjonalnego nagrywania dźwięku.",
                            Image = "mikrofon_usb.jpg",
                            Name = "Mikrofon USB",
                            Price = 129.99m
                        },
                        new
                        {
                            Id = 13,
                            Description = "Quadcopter z wbudowaną kamerą do fotografii lotniczej.",
                            Image = "drone.jpg",
                            Name = "Drone",
                            Price = 299.99m
                        },
                        new
                        {
                            Id = 14,
                            Description = "Szybka drukarka laserowa do efektywnego drukowania dokumentów.",
                            Image = "drukarka_laserowa.jpg",
                            Name = "Drukarka laserowa",
                            Price = 199.99m
                        },
                        new
                        {
                            Id = 15,
                            Description = "Potężny router Wi-Fi zapewniający szybkie i niezawodne połączenie internetowe.",
                            Image = "router_wifi.jpg",
                            Name = "Router Wi-Fi",
                            Price = 99.99m
                        },
                        new
                        {
                            Id = 16,
                            Description = "Przenośny zewnętrzny dysk twardy do bezpiecznego przechowywania danych.",
                            Image = "zewnetrzny_dysk_twardy.jpg",
                            Name = "Zewnętrzny dysk twardy",
                            Price = 129.99m
                        },
                        new
                        {
                            Id = 17,
                            Description = "Przenośna konsola do gier dla rozgrywki w podróży.",
                            Image = "konsola_do_gier_przenosna.jpg",
                            Name = "Konsola do gier przenośna",
                            Price = 199.99m
                        },
                        new
                        {
                            Id = 18,
                            Description = "Kamera sportowa do rejestrowania przygód i aktywności na świeżym powietrzu.",
                            Image = "kamera_sportowa.jpg",
                            Name = "Kamera sportowa",
                            Price = 149.99m
                        },
                        new
                        {
                            Id = 19,
                            Description = "Przyjazny dla dzieci smartwatch z funkcją GPS i kontrolą rodzicielską.",
                            Image = "smartwatch_dla_dzieci.jpg",
                            Name = "Smartwatch dla dzieci",
                            Price = 79.99m
                        },
                        new
                        {
                            Id = 20,
                            Description = "Projektor o wysokiej rozdzielczości do kinowych doznań w domu.",
                            Image = "projektor.jpg",
                            Name = "Projektor",
                            Price = 499.99m
                        });
                });

            modelBuilder.Entity("ShoplateAPP.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Wittiga 1",
                            City = "Wroclaw",
                            OrderDate = new DateTime(2023, 6, 5, 20, 9, 6, 382, DateTimeKind.Local).AddTicks(171),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("ShoplateAPP.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsAdmin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "shoplate@gmail.pl",
                            IsAdmin = "true",
                            Name = "Janusz",
                            Password = "12345",
                            Phone = "516545123",
                            Surname = "Kowalski",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("ShoplateAPP.Models.Item", b =>
                {
                    b.HasOne("ShoplateAPP.Models.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ShoplateAPP.Models.Order", b =>
                {
                    b.HasOne("ShoplateAPP.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShoplateAPP.Models.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("ShoplateAPP.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
