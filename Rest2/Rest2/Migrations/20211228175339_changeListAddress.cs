using Microsoft.EntityFrameworkCore.Migrations;

namespace Rest2.Migrations
{
    public partial class changeListAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_UserIdUser",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_UserIdUser",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "UserIdUser",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "IdNavigationId",
                table: "User",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_IdNavigationId",
                table: "User",
                column: "IdNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_IdNavigationId",
                table: "User",
                column: "IdNavigationId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_IdNavigationId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_IdNavigationId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdNavigationId",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserIdUser",
                table: "Address",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserIdUser",
                table: "Address",
                column: "UserIdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_UserIdUser",
                table: "Address",
                column: "UserIdUser",
                principalTable: "User",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
