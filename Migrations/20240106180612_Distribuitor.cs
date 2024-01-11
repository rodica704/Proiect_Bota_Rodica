using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Bota_Rodica.Migrations
{
    public partial class Distribuitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distribuitor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeDistribuitor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistribuitorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuitor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Distribuitor_Distribuitor_DistribuitorID",
                        column: x => x.DistribuitorID,
                        principalTable: "Distribuitor",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Distribuitor_DistribuitorID",
                table: "Distribuitor",
                column: "DistribuitorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Distribuitor");
        }
    }
}
