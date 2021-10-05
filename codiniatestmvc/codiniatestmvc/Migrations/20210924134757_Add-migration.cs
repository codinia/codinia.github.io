using Microsoft.EntityFrameworkCore.Migrations;

namespace codiniatestmvc.Migrations
{
    public partial class Addmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Blog_Title = table.Column<string>(nullable: true),
                    Blog_Image = table.Column<string>(nullable: true),
                    blog_Content = table.Column<string>(nullable: true),
                    Author_Name = table.Column<string>(nullable: true),
                    Author_Link = table.Column<string>(nullable: true),
                    BlogPost_Tags = table.Column<string>(nullable: true),
                    Blog_Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
