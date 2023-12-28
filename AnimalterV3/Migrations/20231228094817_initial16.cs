using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalterV3.Migrations
{
    /// <inheritdoc />
    public partial class initial16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Types_(TypeId)",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_(TypeId)",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "(TypeId)",
                table: "Animals");

            migrationBuilder.AddColumn<int>(
                name: "(TypeId)",
                table: "AdoptionStatuses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionStatuses_(TypeId)",
                table: "AdoptionStatuses",
                column: "(TypeId)");

            migrationBuilder.AddForeignKey(
                name: "FK_AdoptionStatuses_Animals_(TypeId)",
                table: "AdoptionStatuses",
                column: "(TypeId)",
                principalTable: "Animals",
                principalColumn: "AnimalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdoptionStatuses_Animals_(TypeId)",
                table: "AdoptionStatuses");

            migrationBuilder.DropIndex(
                name: "IX_AdoptionStatuses_(TypeId)",
                table: "AdoptionStatuses");

            migrationBuilder.DropColumn(
                name: "(TypeId)",
                table: "AdoptionStatuses");

            migrationBuilder.AddColumn<int>(
                name: "(TypeId)",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_(TypeId)",
                table: "Animals",
                column: "(TypeId)");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Types_(TypeId)",
                table: "Animals",
                column: "(TypeId)",
                principalTable: "Types",
                principalColumn: "TypeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
