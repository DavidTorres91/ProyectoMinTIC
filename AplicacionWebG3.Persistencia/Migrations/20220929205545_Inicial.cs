using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AplicacionWebG3.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SisPago = table.Column<int>(type: "int", nullable: false),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Contacto = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calendario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personas_TipoDocumentos_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Profesionales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calendario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumLicencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    expLicencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SisPago = table.Column<int>(type: "int", nullable: false),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Contacto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profesionales_TipoDocumentos_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personas_TipoDocumentoId",
                table: "personas",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_TipoDocumentoId",
                table: "Profesionales",
                column: "TipoDocumentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "Profesionales");

            migrationBuilder.DropTable(
                name: "TipoDocumentos");
        }
    }
}
