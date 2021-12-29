using Microsoft.EntityFrameworkCore.Migrations;

namespace Rest2.Migrations
{
    public partial class addIdAddressInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IdNavigation",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_IdNavigation",
                table: "User",
                column: "IdNavigation");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_IdNavigation",
                table: "User",
                column: "IdNavigation",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_IdNavigation",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_IdNavigation",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdNavigation",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "IdNavigationId",
                table: "User",
                type: "int",
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
    }
}
