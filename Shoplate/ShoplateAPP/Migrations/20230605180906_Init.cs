using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoplateAPP.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsAdmin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Image", "Name", "OrderId", "Price" },
                values: new object[,]
                {
                    { 1, "Wysokiej jakości aparat cyfrowy do rejestrowania niesamowitych zdjęć i filmów.", "kamera.jpg", "Kamera", null, 499.99m },
                    { 2, "Telewizor Ultra HD z żywym wyświetlaczem i inteligentnymi funkcjami.", "telewizor_4k.jpg", "Telewizor 4K", null, 999.99m },
                    { 3, "Potężny laptop z szybkim procesorem i dużą ilością miejsca na dane, idealny do pracy.", "laptop.jpg", "Laptop", null, 899.99m },
                    { 4, "Konsola do gier zapewniająca wciągające doznania podczas grania.", "konsola_do_gier.jpg", "Konsola do gier", null, 399.99m },
                    { 5, "Smartfon z bogatymi funkcjami, wysoką rozdzielczością aparatu i długim czasem pracy baterii.", "smartfon.jpg", "Smartfon", null, 699.99m },
                    { 6, "Uniwersalny tablet do pracy i rozrywki w podróży.", "tablet.jpg", "Tablet", null, 299.99m },
                    { 7, "Klawiatura mechaniczna zapewniająca taktylne doświadczenia podczas pisania.", "klawiatura_mechaniczna.jpg", "Klawiatura mechaniczna", null, 149.99m },
                    { 8, "Mysz gamingowa z możliwością personalizacji przycisków i wysokim DPI.", "mysz_gamingowa.jpg", "Mysz gamingowa", null, 79.99m },
                    { 9, "Monitor o wysokiej rozdzielczości dla wyraźnych obrazów i płynnej pracy.", "monitor.jpg", "Monitor", null, 299.99m },
                    { 10, "Głośniki do komputera zapewniające immersyjne brzmienie podczas gier i multimediów.", "glosniki_komputerowe.jpg", "Głośniki komputerowe", null, 49.99m },
                    { 11, "Słuchawki gamingowe z dźwiękiem przestrzennym i redukcją hałasu.", "sluchawki_gamingowe.jpg", "Słuchawki gamingowe", null, 149.99m },
                    { 12, "Mikrofon USB do profesjonalnego nagrywania dźwięku.", "mikrofon_usb.jpg", "Mikrofon USB", null, 129.99m },
                    { 13, "Quadcopter z wbudowaną kamerą do fotografii lotniczej.", "drone.jpg", "Drone", null, 299.99m },
                    { 14, "Szybka drukarka laserowa do efektywnego drukowania dokumentów.", "drukarka_laserowa.jpg", "Drukarka laserowa", null, 199.99m },
                    { 15, "Potężny router Wi-Fi zapewniający szybkie i niezawodne połączenie internetowe.", "router_wifi.jpg", "Router Wi-Fi", null, 99.99m },
                    { 16, "Przenośny zewnętrzny dysk twardy do bezpiecznego przechowywania danych.", "zewnetrzny_dysk_twardy.jpg", "Zewnętrzny dysk twardy", null, 129.99m },
                    { 17, "Przenośna konsola do gier dla rozgrywki w podróży.", "konsola_do_gier_przenosna.jpg", "Konsola do gier przenośna", null, 199.99m },
                    { 18, "Kamera sportowa do rejestrowania przygód i aktywności na świeżym powietrzu.", "kamera_sportowa.jpg", "Kamera sportowa", null, 149.99m },
                    { 19, "Przyjazny dla dzieci smartwatch z funkcją GPS i kontrolą rodzicielską.", "smartwatch_dla_dzieci.jpg", "Smartwatch dla dzieci", null, 79.99m },
                    { 20, "Projektor o wysokiej rozdzielczości do kinowych doznań w domu.", "projektor.jpg", "Projektor", null, 499.99m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Name", "Password", "Phone", "Surname", "Username" },
                values: new object[] { 1, "shoplate@gmail.pl", "true", "Janusz", "12345", "516545123", "Kowalski", "admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "City", "OrderDate", "UserId" },
                values: new object[] { 1, "Wittiga 1", "Wroclaw", new DateTime(2023, 6, 5, 20, 9, 6, 382, DateTimeKind.Local).AddTicks(171), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Items_OrderId",
                table: "Items",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
