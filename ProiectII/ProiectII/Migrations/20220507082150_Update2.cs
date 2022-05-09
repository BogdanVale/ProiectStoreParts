using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectII.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/L0538Kz/clapeta-Admisie.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg");
        }
    }
}
