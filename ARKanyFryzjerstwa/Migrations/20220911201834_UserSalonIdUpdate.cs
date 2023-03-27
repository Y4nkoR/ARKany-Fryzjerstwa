using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ARKanyFryzjerstwa.Migrations
{
    public partial class UserSalonIdUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Salons_SalonId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_SalonId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "SalonId",
                table: "Appointments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalonId",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SalonId",
                table: "Appointments",
                column: "SalonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Salons_SalonId",
                table: "Appointments",
                column: "SalonId",
                principalTable: "Salons",
                principalColumn: "Id");
        }
    }
}
