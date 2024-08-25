using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoiSell.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedCategoryTableToDbAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Business" },
                    { 2, "Computer & Technology" },
                    { 3, "Education" },
                    { 4, "Health & Fitness" },
                    { 5, "History" },
                    { 6, "Home & Garden" },
                    { 7, "Horror" },
                    { 8, "Medical & Nursing" },
                    { 9, "Mystery & Thrillers" },
                    { 10, "Poetry" },
                    { 11, "Religion" },
                    { 12, "Science Fiction" },
                    { 13, "Self Help" },
                    { 14, "Sports & Recreation" },
                    { 15, "Travel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
