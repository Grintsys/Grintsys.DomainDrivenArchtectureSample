using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Grintsys.SROverview.Migrations
{
    public partial class AddClientEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    IdNumber = table.Column<string>(nullable: true),
                    Longitude = table.Column<decimal>(nullable: false),
                    Latitud = table.Column<decimal>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Celphone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Sexo = table.Column<int>(nullable: false),
                    BithDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
