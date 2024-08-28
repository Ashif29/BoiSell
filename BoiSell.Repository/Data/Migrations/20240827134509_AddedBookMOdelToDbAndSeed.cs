using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoiSell.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookMOdelToDbAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    SpecialTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Pages = table.Column<int>(type: "int", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Discount", "ISBN", "ImageUrl", "Language", "Pages", "Price", "PublishedDate", "Publisher", "SpecialTag", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "James Clear", 1, "Tiny Changes, Remarkable Results.No matter your goals, Atomic Habits offers a proven framework for improving--every day. James Clear, one of the world's leading experts on habit formation, reveals practical strategies that will teach you exactly how to form good habits, break bad ones, and master the tiny behaviors that lead to remarkable results.", 5, "e8e5777a-0b90-4f8b-b5a5-a252bdee2fb4", "/images/books/AtomicHabits.jpg", "English", 180, 1000, new DateOnly(1925, 4, 10), "Scribner", "Classic", 0, "Atomic Habits" },
                    { 2, "Yuval Noah Harari", 2, "A look at the history and impact of Homo sapiens.The book, focusing on Homo sapiens, surveys the history of humankind, starting from the Stone Age and going up to the twenty-first century.", 0, "4663cae6-26ba-4e70-88f0-482ea599bd75", "/images/books/BlueChristanity.jpg", "English", 443, 300, new DateOnly(2011, 9, 4), "Harvill Secker", "Bestseller", 0, "Sapiens: A Brief History of Humankind" },
                    { 3, "Stephen Hawking", 3, "A landmark book in cosmology.A simple summary of A Brief History of Time goes all the way from the beginning of the universe to its end, explaining things like space and time, the expanding universe, the uncertainty principle, black holes, wormholes, and time travel along the way. It sold over 25 million copies.", 10, "b45741b1-6099-4dc2-89dd-33444769a8cd", "/images/books/Celopatra.jpg", "English", 212, 120, new DateOnly(1988, 3, 1), "Bantam Books", "Science", 0, "A Brief History of Time" },
                    { 4, "Stephenie Meyer", 4, "A vampire romance novel.Twilight is a captivating novel by Stephenie Meyer. Set in the small town of Forks, it tells the story of Bella, a teenager who falls in love with a vampire named Edward. Their unconventional relationship unfolds in a world where love and danger collide.", 0, "2e169ccf-735e-4406-b9d8-5c921fadc693", "/images/books/twilight.jpg", "English", 498, 900, new DateOnly(2005, 10, 5), "Little, Brown and Company", "Popular", 0, "Twilight" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Self Help");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Horror");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Business");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Health & Fitness");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Computer & Technology");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Business");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Computer & Technology");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Health & Fitness");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Horror");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Self Help");
        }
    }
}
