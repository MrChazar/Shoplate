using Microsoft.EntityFrameworkCore;
using ShoplateAPP.Models;
using System.Diagnostics;

namespace ShoplateAPP.Data
{
    public class DatabaseContext : DbContext
    {
        

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<User> Users { get; set; } 

        public DbSet<Order> Orders { get; set; }


        // Probably good relations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasOne<Order>(s => s.Order)
                .WithMany(g => g.Items)
                .HasForeignKey(s => s.OrderId);
            modelBuilder.Entity<Order>()
                .HasOne<User>(s => s.User)
                .WithMany(g => g.Orders)
                .HasForeignKey(s => s.UserId);
            
            modelBuilder.Entity<Item>().HasData(
                new Item(1, "Kamera", "Wysokiej jakości aparat cyfrowy do rejestrowania niesamowitych zdjęć i filmów.", "kamera.jpg", 499.99M),
                new Item(2, "Telewizor 4K", "Telewizor Ultra HD z żywym wyświetlaczem i inteligentnymi funkcjami.", "telewizor_4k.jpg", 999.99M),
                new Item(3, "Laptop", "Potężny laptop z szybkim procesorem i dużą ilością miejsca na dane, idealny do pracy.", "laptop.jpg", 899.99M),
                new Item(4, "Konsola do gier", "Konsola do gier zapewniająca wciągające doznania podczas grania.", "konsola_do_gier.jpg", 399.99M),
                new Item(5, "Smartfon", "Smartfon z bogatymi funkcjami, wysoką rozdzielczością aparatu i długim czasem pracy baterii.", "smartfon.jpg", 699.99M),
                new Item(6, "Tablet", "Uniwersalny tablet do pracy i rozrywki w podróży.", "tablet.jpg", 299.99M),
                new Item(7, "Klawiatura mechaniczna", "Klawiatura mechaniczna zapewniająca taktylne doświadczenia podczas pisania.", "klawiatura_mechaniczna.jpg", 149.99M),
                new Item(8, "Mysz gamingowa", "Mysz gamingowa z możliwością personalizacji przycisków i wysokim DPI.", "mysz_gamingowa.jpg", 79.99M),
                new Item(9, "Monitor", "Monitor o wysokiej rozdzielczości dla wyraźnych obrazów i płynnej pracy.", "monitor.jpg", 299.99M),
                new Item(10, "Głośniki komputerowe", "Głośniki do komputera zapewniające immersyjne brzmienie podczas gier i multimediów.", "glosniki_komputerowe.jpg", 49.99M),
                new Item(11, "Słuchawki gamingowe", "Słuchawki gamingowe z dźwiękiem przestrzennym i redukcją hałasu.", "sluchawki_gamingowe.jpg", 149.99M),
                new Item(12, "Mikrofon USB", "Mikrofon USB do profesjonalnego nagrywania dźwięku.", "mikrofon_usb.jpg", 129.99M),
                new Item(13, "Drone", "Quadcopter z wbudowaną kamerą do fotografii lotniczej.", "drone.jpg", 299.99M),
                new Item(14, "Drukarka laserowa", "Szybka drukarka laserowa do efektywnego drukowania dokumentów.", "drukarka_laserowa.jpg", 199.99M),
                new Item(15, "Router Wi-Fi", "Potężny router Wi-Fi zapewniający szybkie i niezawodne połączenie internetowe.", "router_wifi.jpg", 99.99M),
                new Item(16, "Zewnętrzny dysk twardy", "Przenośny zewnętrzny dysk twardy do bezpiecznego przechowywania danych.", "zewnetrzny_dysk_twardy.jpg", 129.99M),
                new Item(17, "Konsola do gier przenośna", "Przenośna konsola do gier dla rozgrywki w podróży.", "konsola_do_gier_przenosna.jpg", 199.99M),
                new Item(18, "Kamera sportowa", "Kamera sportowa do rejestrowania przygód i aktywności na świeżym powietrzu.", "kamera_sportowa.jpg", 149.99M),
                new Item(19, "Smartwatch dla dzieci", "Przyjazny dla dzieci smartwatch z funkcją GPS i kontrolą rodzicielską.", "smartwatch_dla_dzieci.jpg", 79.99M),
                new Item(20, "Projektor", "Projektor o wysokiej rozdzielczości do kinowych doznań w domu.", "projektor.jpg", 499.99M)
                );
            modelBuilder.Entity<User>().HasData(
                new User(1, "Janusz", "Kowalski", "516545123", "shoplate@gmail.pl", "12345", "true", "admin")
            );
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    UserId = 1,
                    OrderDate = DateTime.Now,
                    City = "Wroclaw",
                    Address = "Wittiga 1"
                }
            );
        }
    }
}

