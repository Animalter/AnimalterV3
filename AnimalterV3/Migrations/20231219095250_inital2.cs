using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalterV3.Migrations
{
    /// <inheritdoc />
    public partial class inital2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genus_Types_TypeId",
                table: "Genus");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Genus");

            migrationBuilder.RenameColumn(
                name: "Typee",
                table: "Types",
                newName: "Typeee");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Genus",
                newName: "TypeeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Genus_TypeId",
                table: "Genus",
                newName: "IX_Genus_TypeeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genus_Types_TypeeTypeId",
                table: "Genus",
                column: "TypeeTypeId",
                principalTable: "Types",
                principalColumn: "TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genus_Types_TypeeTypeId",
                table: "Genus");

            migrationBuilder.RenameColumn(
                name: "Typeee",
                table: "Types",
                newName: "Typee");

            migrationBuilder.RenameColumn(
                name: "TypeeTypeId",
                table: "Genus",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Genus_TypeeTypeId",
                table: "Genus",
                newName: "IX_Genus_TypeId");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Genus",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Genus_Types_TypeId",
                table: "Genus",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "TypeId");
        }
    }
}
