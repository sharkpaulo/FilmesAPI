using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmesAPI.Migrations
{
    /// <inheritdoc />
    public partial class CinemaeFilme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Cinemas_FilmeId",
                table: "Sessoes");

            migrationBuilder.CreateIndex(
                name: "IX_Sessoes_CinemaId",
                table: "Sessoes",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Cinemas_CinemaId",
                table: "Sessoes",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Cinemas_CinemaId",
                table: "Sessoes");

            migrationBuilder.DropIndex(
                name: "IX_Sessoes_CinemaId",
                table: "Sessoes");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Cinemas_FilmeId",
                table: "Sessoes",
                column: "FilmeId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
