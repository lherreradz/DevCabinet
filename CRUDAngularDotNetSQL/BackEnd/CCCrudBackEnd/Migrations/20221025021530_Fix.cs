using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NúmeroTarjeta",
                table: "TarjetaCredito",
                newName: "NumeroTarjeta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumeroTarjeta",
                table: "TarjetaCredito",
                newName: "NúmeroTarjeta");
        }
    }
}
