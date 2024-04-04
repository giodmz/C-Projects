using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] {"Eagles","caras fodas", "(foto)" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] {"Pato Viúvo","celo rock", "(foto)" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] {"BLACKPINK","mulheres fodas", "(foto)" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] {"Travis Scott","cara foda", "(foto)" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] {"Iron Mainden","caras fodas", "(foto)" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] {"Guguti Mentality","mentalidade de vencedor", "(foto)" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
