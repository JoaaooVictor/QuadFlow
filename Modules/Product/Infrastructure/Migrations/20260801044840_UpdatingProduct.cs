using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price_Value",
                schema: "Products",
                table: "Product",
                newName: "Price");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                schema: "Products",
                table: "Product",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                schema: "Products",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                schema: "Products",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Price",
                schema: "Products",
                table: "Product",
                newName: "Price_Value");

            migrationBuilder.AlterColumn<double>(
                name: "Price_Value",
                schema: "Products",
                table: "Product",
                type: "float",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);
        }
    }
}
