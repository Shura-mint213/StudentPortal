using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class EditTitleStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "6a37dd50-e9ca-48b6-910b-1db4bf1010a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55212e65-8569-5ad7-b12a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "e5bc9d55-c7da-42b9-84b1-22f23ef363ac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "564c1d67-17a2-447b-b5b1-4a6f770da216", "AQAAAAEAACcQAAAAEBSXELcFpMSphvy0xOuoXuHurBGonM7uwLuwS3HsFfs/6n2P/DE1X8plD3mtDWgjqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b62452e-4f66-49fa-a20f-e7521b1355d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76ef992c-0d9f-4350-af0b-0860831e544b", "AQAAAAEAACcQAAAAEF/FG4SBBSjV7i2QRK5CY3Vh+7zznfS1RcPpyjqRCR8lQ9MTmkovHD1+gweKY1ozuw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 10, 7, 57, 16, 585, DateTimeKind.Utc).AddTicks(4115), null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5aa21a4c-c16d-932a-14c1-06e6487a643a"),
                columns: new[] { "DateAdded", "Title", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 10, 7, 57, 16, 585, DateTimeKind.Utc).AddTicks(4256), "Страница студента", null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 10, 7, 57, 16, 584, DateTimeKind.Utc).AddTicks(8928), null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 10, 7, 57, 16, 585, DateTimeKind.Utc).AddTicks(3868), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "0fe1ccd0-ff56-471b-9e9d-b91cfa32af26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55212e65-8569-5ad7-b12a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a58b5d88-fb80-43e1-94ef-9fa1a19d10b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d67fd3a8-bccd-4508-9bc8-599e75200979", "AQAAAAEAACcQAAAAEP7nhPyYBv0oXiOLrGoPvdPaHxfVGM7XggubsAyaubfmSOeQQbWMDVDVQ4yblIRW9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b62452e-4f66-49fa-a20f-e7521b1355d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae5d84ae-b823-4115-aeca-74ffc57e2991", "AQAAAAEAACcQAAAAEOkLoni4u71q1cB3If8tBMcFeNZlg3n/ZLcL9SYyhksYlCS7EZ5kKP30mM5sZiM3AA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 10, 3, 13, 44, 686, DateTimeKind.Utc).AddTicks(8176), "Содержание заполняется администратором" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5aa21a4c-c16d-932a-14c1-06e6487a643a"),
                columns: new[] { "DateAdded", "Title", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 10, 3, 13, 44, 686, DateTimeKind.Utc).AddTicks(8481), "Расписание", "Содержание заполняется администратором" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 10, 3, 13, 44, 685, DateTimeKind.Utc).AddTicks(6059), "Содержание заполняется администратором" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 10, 3, 13, 44, 686, DateTimeKind.Utc).AddTicks(7589), "Содержание заполняется администратором" });
        }
    }
}
