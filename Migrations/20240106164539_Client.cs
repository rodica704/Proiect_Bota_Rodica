using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Bota_Rodica.Migrations
{
    public partial class Client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Produs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeClient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumarComanda = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Client_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produs_ClientID",
                table: "Produs",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ClientID",
                table: "Client",
                column: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produs_Client_ClientID",
                table: "Produs",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produs_Client_ClientID",
                table: "Produs");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Produs_ClientID",
                table: "Produs");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Produs");
        }
    }
}
