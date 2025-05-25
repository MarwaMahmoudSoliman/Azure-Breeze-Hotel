using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp3.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "frontend",
                columns: table => new
                {
                    user_name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pass_word = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_frontend", x => x.user_name);
                });

            migrationBuilder.CreateTable(
                name: "kitchen",
                columns: table => new
                {
                    user_name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pass_word = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitchen", x => x.user_name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "frontend");

            migrationBuilder.DropTable(
                name: "kitchen");
        }
    }
}
