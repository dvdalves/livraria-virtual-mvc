using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LivrariaVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Livros",
                newName: "Idioma");

            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Livros",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "Idioma",
                table: "Livros",
                newName: "Tipo");
        }
    }
}
