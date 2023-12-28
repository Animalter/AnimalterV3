using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalterV3.Migrations
{
    /// <inheritdoc />
    public partial class initial15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Typeee",
                table: "Animals");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Typeee",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
