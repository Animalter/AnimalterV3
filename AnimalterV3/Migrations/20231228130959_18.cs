using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalterV3.Migrations
{
    /// <inheritdoc />
    public partial class _18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdoptionStatuses_Customers_CustomerId",
                table: "AdoptionStatuses");

            migrationBuilder.DropIndex(
                name: "IX_AdoptionStatuses_CustomerId",
                table: "AdoptionStatuses");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "AdoptionStatuses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "AdoptionStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionStatuses_CustomerId",
                table: "AdoptionStatuses",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdoptionStatuses_Customers_CustomerId",
                table: "AdoptionStatuses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
