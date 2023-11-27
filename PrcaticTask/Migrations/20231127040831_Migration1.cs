using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrcaticTask.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brand_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active_status = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active_status = table.Column<byte>(type: "tinyint", nullable: false),
                    brand_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.id);
                    table.ForeignKey(
                        name: "FK_Model_Brand_brand_id",
                        column: x => x.brand_id,
                        principalTable: "Brand",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Model_brand_id",
                table: "Model",
                column: "brand_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
