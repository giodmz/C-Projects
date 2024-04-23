using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCinema.Migrations
{
    /// <inheritdoc />
    public partial class AddItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Itens", new string[] { "Nome", "Preco" }, new object[] { "Arroz", "7,99" });
            migrationBuilder.InsertData("Itens", new string[] { "Nome", "Preco" }, new object[] { "Batata", "8,99" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Itens");
        }
    }
}
