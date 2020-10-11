using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class addmoreproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "Orderdate", "Price", "Shelf" },
                values: new object[] { 1, "livingroom", 5, "60 inches ", "tv", new DateTime(2008, 3, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 20000, "B110" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "Orderdate", "Price", "Shelf" },
                values: new object[] { 2, "kitchen", 5, "medums ", "dish", new DateTime(2018, 3, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 50, "A10" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "Orderdate", "Price", "Shelf" },
                values: new object[] { 3, "livingroom", 5, "black ", "radio", new DateTime(2020, 3, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), 1000, "C110" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
