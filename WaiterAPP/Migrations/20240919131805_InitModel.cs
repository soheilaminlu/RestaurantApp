using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WaiterAPP.Migrations
{
    /// <inheritdoc />
    public partial class InitModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    FoodCategory = table.Column<int>(type: "integer", nullable: true),
                    IsPopular = table.Column<bool>(type: "boolean", nullable: false),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    StockQuantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Waiters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waiters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Appetizer = table.Column<string>(type: "text", nullable: true),
                    AppetizerQuantity = table.Column<int>(type: "integer", nullable: false),
                    MainCourse = table.Column<string>(type: "text", nullable: true),
                    MainCourseQuantity = table.Column<int>(type: "integer", nullable: false),
                    Dessert = table.Column<string>(type: "text", nullable: true),
                    DessertQuantity = table.Column<int>(type: "integer", nullable: false),
                    AppetizerPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    MainCoursePrice = table.Column<decimal>(type: "numeric", nullable: false),
                    DessertPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    WaiterId = table.Column<int>(type: "integer", nullable: false),
                    OrderStatus = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Waiters_WaiterId",
                        column: x => x.WaiterId,
                        principalTable: "Waiters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WaiterId",
                table: "Orders",
                column: "WaiterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Waiters");
        }
    }
}
