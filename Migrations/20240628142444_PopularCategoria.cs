using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC2022.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
             name: "MyProperty2",
             table: "Categorias");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
                "VALUES('Normal','Lanche feito com ingredientes comuns')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
               "VALUES('Natural','Lanche feito com ingredientes integrais e naturais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
