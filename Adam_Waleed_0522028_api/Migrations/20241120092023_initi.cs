using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adam_Waleed_0522028_api.Migrations
{
    /// <inheritdoc />
    public partial class initi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category_ms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_ms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nationality_ms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectoirId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nationality_ms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "director_Ms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_director_Ms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_director_Ms_nationality_ms_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "nationality_ms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movies_Ms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Director_MId = table.Column<int>(type: "int", nullable: true),
                    Movies_MId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies_Ms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movies_Ms_category_ms_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category_ms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movies_Ms_director_Ms_Director_MId",
                        column: x => x.Director_MId,
                        principalTable: "director_Ms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_movies_Ms_movies_Ms_Movies_MId",
                        column: x => x.Movies_MId,
                        principalTable: "movies_Ms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_director_Ms_NationalityId",
                table: "director_Ms",
                column: "NationalityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movies_Ms_CategoryId",
                table: "movies_Ms",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_movies_Ms_Director_MId",
                table: "movies_Ms",
                column: "Director_MId");

            migrationBuilder.CreateIndex(
                name: "IX_movies_Ms_Movies_MId",
                table: "movies_Ms",
                column: "Movies_MId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies_Ms");

            migrationBuilder.DropTable(
                name: "category_ms");

            migrationBuilder.DropTable(
                name: "director_Ms");

            migrationBuilder.DropTable(
                name: "nationality_ms");
        }
    }
}
