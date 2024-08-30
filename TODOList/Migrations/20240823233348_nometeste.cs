using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TODOList.Migrations
{
    public partial class nometeste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TODOs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Tarefa = table.Column<string>(maxLength: 2000, nullable: false),
                    Descricao = table.Column<string>(maxLength: 2000, nullable: false),
                    Feito = table.Column<int>(nullable: false) // Alterado para int para evitar erro
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TODOs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TODOs");
        }
    }
}