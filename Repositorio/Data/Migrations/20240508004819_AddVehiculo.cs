using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasPorMenos.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "Conductor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conductor_VehiculoId",
                table: "Conductor",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conductor_Vehiculo_VehiculoId",
                table: "Conductor",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conductor_Vehiculo_VehiculoId",
                table: "Conductor");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Conductor_VehiculoId",
                table: "Conductor");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "Conductor");
        }
    }
}
