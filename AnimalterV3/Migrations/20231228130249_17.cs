using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalterV3.Migrations
{
    /// <inheritdoc />
    public partial class _17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AdoptionStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionStatuses_UserId",
                table: "AdoptionStatuses",
                column: "UserId");

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

            migrationBuilder.DropIndex(
                name: "IX_AdoptionStatuses_UserId",
                table: "AdoptionStatuses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AdoptionStatuses");
        }
    }
}
