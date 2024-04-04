using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "One of these nights", 1945 });
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "One of these night", 1944 });
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "One of these nigh", 1943 });
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "One of these nig", 1942 });
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "One of these ni", 1941 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
