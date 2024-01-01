using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalterV3.Migrations
{
    /// <inheritdoc />
    public partial class _20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdoptionStatuses_Customers_CustomerId",
                table: "AdoptionStatuses");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "AdoptionStatuses",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AdoptionStatuses_CustomerId",
                table: "AdoptionStatuses",
                newName: "IX_AdoptionStatuses_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdoptionStatuses_UserTbls_UserId",
                table: "AdoptionStatuses",
                column: "UserId",
                principalTable: "UserTbls",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdoptionStatuses_UserTbls_UserId",
                table: "AdoptionStatuses");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AdoptionStatuses",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_AdoptionStatuses_UserId",
                table: "AdoptionStatuses",
                newName: "IX_AdoptionStatuses_CustomerId");

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
