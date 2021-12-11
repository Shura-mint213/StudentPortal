using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class NewDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "f841aca0-5d54-4972-bab4-f31288e40755");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55212e65-8569-5ad7-b12a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "786489df-8a84-4e3a-9c14-ffb29372924f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f61913af-995f-4979-aba7-a81dfce8d428", "AQAAAAEAACcQAAAAEPKqxgeR51a1v9Ttr+JJqwI5STRkrYhsfOCEEHSjP2tCqVzoqY1cPvh/tatf1QdRZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b62452e-4f66-49fa-a20f-e7521b1355d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a46cb106-5021-4cda-970e-4586e0a842c6", "AQAAAAEAACcQAAAAEMK7UfK3FhyauyTGVGTGEBsfi2Xd0N8UhzvxfYeN5h7vw8PcFG1zsieGHqEw0BSgKA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 11, 9, 43, 42, 26, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5aa21a4c-c16d-932a-14c1-06e6487a643a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 11, 9, 43, 42, 26, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 11, 9, 43, 42, 25, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 11, 9, 43, 42, 26, DateTimeKind.Utc).AddTicks(460));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "d75a271b-74b3-48e1-bb2a-63bed59fee58");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55212e65-8569-5ad7-b12a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "1029a898-534c-4de0-b3ff-e0da59dcde09");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "754eb058-bcfd-4ade-a1ad-1a76cb48082e", "AQAAAAEAACcQAAAAEJltAZaQHw67vWaN3v+lR002swLgyCprDjEz631xng26CHqvFzCIPZ6jw6Z215Ox1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b62452e-4f66-49fa-a20f-e7521b1355d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09746200-4ca4-404f-8684-e9df1daf1a87", "AQAAAAEAACcQAAAAEM2yzGWdCT450W1AEEflzUTl2b/29yTSLCNkllpnU8kBhNhAkoGXAWkXk45czBOIfQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 11, 9, 36, 51, 545, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5aa21a4c-c16d-932a-14c1-06e6487a643a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 11, 9, 36, 51, 545, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 11, 9, 36, 51, 544, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 11, 9, 36, 51, 545, DateTimeKind.Utc).AddTicks(1130));
        }
    }
}
