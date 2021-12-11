using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class NewRolte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 7, 57, 16, 585, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5aa21a4c-c16d-932a-14c1-06e6487a643a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 7, 57, 16, 585, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 7, 57, 16, 584, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 7, 57, 16, 585, DateTimeKind.Utc).AddTicks(3868));
        }
    }
}
