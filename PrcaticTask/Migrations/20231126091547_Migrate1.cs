using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrcaticTask.Migrations
{
    /// <inheritdoc />
    public partial class Migrate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Brand_BrandId",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Brand");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Model",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Model",
                newName: "brand_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Model",
                newName: "model_name");

            migrationBuilder.RenameIndex(
                name: "IX_Model_BrandId",
                table: "Model",
                newName: "IX_Model_brand_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Brand",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Brand",
                newName: "brand_name");

            migrationBuilder.AddColumn<byte>(
                name: "active_status",
                table: "Model",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "active_status",
                table: "Brand",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Brand_brand_id",
                table: "Model",
                column: "brand_id",
                principalTable: "Brand",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Brand_brand_id",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "active_status",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "active_status",
                table: "Brand");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Model",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "brand_id",
                table: "Model",
                newName: "BrandId");

            migrationBuilder.RenameColumn(
                name: "model_name",
                table: "Model",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Model_brand_id",
                table: "Model",
                newName: "IX_Model_BrandId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Brand",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "brand_name",
                table: "Brand",
                newName: "Name");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Model",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Brand",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Brand_BrandId",
                table: "Model",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
