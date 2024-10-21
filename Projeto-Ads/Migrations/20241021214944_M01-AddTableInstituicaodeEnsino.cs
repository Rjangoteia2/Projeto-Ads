using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_Ads.Migrations
{
    /// <inheritdoc />
    public partial class M01AddTableInstituicaodeEnsino : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instituição de Ensino",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<int>(type: "int", nullable: false),
                    cursos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvaliacaoMec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvaliacaoProfessor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvaliacaoAluno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preço = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituição de Ensino", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instituição de Ensino");
        }
    }
}
