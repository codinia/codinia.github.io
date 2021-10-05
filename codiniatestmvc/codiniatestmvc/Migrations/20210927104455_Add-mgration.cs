using Microsoft.EntityFrameworkCore.Migrations;

namespace codiniatestmvc.Migrations
{
    public partial class Addmgration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "blog_url",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "blog_url",
                table: "Blogs");
        }
    }
}
