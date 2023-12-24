using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalterV3.Migrations
{
    /// <inheritdoc />
    public partial class inital9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_RoleTbls_RoleTblRoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserTbls_UserTblUserId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "AnmalGenus",
                table: "Animals");

            migrationBuilder.AlterColumn<int>(
                name: "UserTblUserId",
                table: "UserRoles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RoleTblRoleId",
                table: "UserRoles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_RoleTbls_RoleTblRoleId",
                table: "UserRoles",
                column: "RoleTblRoleId",
                principalTable: "RoleTbls",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserTbls_UserTblUserId",
                table: "UserRoles",
                column: "UserTblUserId",
                principalTable: "UserTbls",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_RoleTbls_RoleTblRoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserTbls_UserTblUserId",
                table: "UserRoles");

            migrationBuilder.AlterColumn<int>(
                name: "UserTblUserId",
                table: "UserRoles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoleTblRoleId",
                table: "UserRoles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnmalGenus",
                table: "Animals",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_RoleTbls_RoleTblRoleId",
                table: "UserRoles",
                column: "RoleTblRoleId",
                principalTable: "RoleTbls",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserTbls_UserTblUserId",
                table: "UserRoles",
                column: "UserTblUserId",
                principalTable: "UserTbls",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
