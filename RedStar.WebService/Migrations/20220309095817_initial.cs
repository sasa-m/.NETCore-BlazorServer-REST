using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStar.WebService.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    Born = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Born", "FirstName", "Height", "LastName", "Number", "PhotoPath", "Position" },
                values: new object[,]
                {
                    { 1, 1995, "Dejan", 202, "Davidovac", 7, "images/dejan.png", "Forward" },
                    { 2, 1993, "Luka", 206, "Mitrovic", 9, "images/luka.png", "Forward" },
                    { 3, 1989, "Branko", 195, "Lazic", 10, "images/branko.png", "Guard" },
                    { 4, 1994, "Ognjen", 200, "Dobric", 13, "images/ognjen.png", "Guard" },
                    { 5, 1986, "Marko", 203, "Simonovic", 19, "images/marko.png", "Forward" },
                    { 6, 1994, "Nikola", 191, "Ivanovic", 20, "images/nikola.png", "Guard" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
