using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.App.Persistencia.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instalaciones_Salones_salonid",
                table: "Instalaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instalaciones",
                table: "Instalaciones");

            migrationBuilder.RenameTable(
                name: "Instalaciones",
                newName: "InstalacionesDb");

            migrationBuilder.RenameIndex(
                name: "IX_Instalaciones_salonid",
                table: "InstalacionesDb",
                newName: "IX_InstalacionesDb_salonid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstalacionesDb",
                table: "InstalacionesDb",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_InstalacionesDb_Salones_salonid",
                table: "InstalacionesDb",
                column: "salonid",
                principalTable: "Salones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstalacionesDb_Salones_salonid",
                table: "InstalacionesDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstalacionesDb",
                table: "InstalacionesDb");

            migrationBuilder.RenameTable(
                name: "InstalacionesDb",
                newName: "Instalaciones");

            migrationBuilder.RenameIndex(
                name: "IX_InstalacionesDb_salonid",
                table: "Instalaciones",
                newName: "IX_Instalaciones_salonid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instalaciones",
                table: "Instalaciones",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instalaciones_Salones_salonid",
                table: "Instalaciones",
                column: "salonid",
                principalTable: "Salones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
