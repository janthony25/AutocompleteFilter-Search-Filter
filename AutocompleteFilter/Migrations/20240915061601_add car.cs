using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutocompleteFilter.Migrations
{
    /// <inheritdoc />
    public partial class addcar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_CarId",
                table: "CarModels",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModels_Cars_CarId",
                table: "CarModels",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModels_Cars_CarId",
                table: "CarModels");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_CarModels_CarId",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "CarModels");
        }
    }
}
