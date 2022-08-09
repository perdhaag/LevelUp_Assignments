using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DjHaag.Persitence.Migrations
{
    public partial class AddCompetenceMatricesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompetenceMatrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetenceMatricesCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetenceMatrices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryThemes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompetenceMatriceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryThemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryThemes_CompetenceMatrices_CompetenceMatriceId",
                        column: x => x.CompetenceMatriceId,
                        principalTable: "CompetenceMatrices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryThemes_CompetenceMatriceId",
                table: "CategoryThemes",
                column: "CompetenceMatriceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryThemes");

            migrationBuilder.DropTable(
                name: "CompetenceMatrices");
        }
    }
}
