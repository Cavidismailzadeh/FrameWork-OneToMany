using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_Slider.Migrations
{
    public partial class AddAboutImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutImage_Abouts_AboutId",
                table: "AboutImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AboutImage",
                table: "AboutImage");

            migrationBuilder.DropColumn(
                name: "HeartList",
                table: "Abouts");

            migrationBuilder.RenameTable(
                name: "AboutImage",
                newName: "AboutImages");

            migrationBuilder.RenameIndex(
                name: "IX_AboutImage_AboutId",
                table: "AboutImages",
                newName: "IX_AboutImages_AboutId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AboutImages",
                table: "AboutImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutImages_Abouts_AboutId",
                table: "AboutImages",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutImages_Abouts_AboutId",
                table: "AboutImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AboutImages",
                table: "AboutImages");

            migrationBuilder.RenameTable(
                name: "AboutImages",
                newName: "AboutImage");

            migrationBuilder.RenameIndex(
                name: "IX_AboutImages_AboutId",
                table: "AboutImage",
                newName: "IX_AboutImage_AboutId");

            migrationBuilder.AddColumn<string>(
                name: "HeartList",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AboutImage",
                table: "AboutImage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutImage_Abouts_AboutId",
                table: "AboutImage",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
