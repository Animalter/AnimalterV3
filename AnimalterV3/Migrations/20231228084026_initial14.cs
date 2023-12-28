using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalterV3.Migrations
{
    /// <inheritdoc />
    public partial class initial14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genus_Types_TypeeTypeId",
                table: "Genus");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Types",
                newName: "TypeeId");

            migrationBuilder.RenameColumn(
                name: "TypeeTypeId",
                table: "Genus",
                newName: "TypeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Genus_TypeeTypeId",
                table: "Genus",
                newName: "IX_Genus_TypeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genus_Types_TypeeId",
                table: "Genus",
                column: "TypeeId",
                principalTable: "Types",
                principalColumn: "TypeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genus_Types_TypeeId",
                table: "Genus");

            migrationBuilder.RenameColumn(
                name: "TypeeId",
                table: "Types",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "TypeeId",
                table: "Genus",
                newName: "TypeeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Genus_TypeeId",
                table: "Genus",
                newName: "IX_Genus_TypeeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genus_Types_TypeeTypeId",
                table: "Genus",
                column: "TypeeTypeId",
                principalTable: "Types",
                principalColumn: "TypeId");
        }
    }
}
