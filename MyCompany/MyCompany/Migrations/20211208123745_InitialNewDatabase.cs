using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class InitialNewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "d966cd6a-a4a6-4b9f-9e98-e02dfd2aff65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55212e65-8569-5ad7-b12a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "7b21e065-3433-416f-9de0-acccd6d07888");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b9d05ce-e29b-43fb-b8c1-9363f63a94d9", "AQAAAAEAACcQAAAAEKBQi9/XhcyZEGS6IWT/Q3RE+8BUgPD6Xw8Ef2TmxS1jcNYUMP7VhEbb33tCAWL+ig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b62452e-4f66-49fa-a20f-e7521b1355d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d621e45-47b5-4f84-bd19-5eb7f64bed50", "AQAAAAEAACcQAAAAENHTi2RUvmnyjpdRaDsDNNk3avg9FFeqa7vh7PRmQbH9xrxHU5BMKIGTnuGe067T6A==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 12, 37, 43, 710, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 12, 37, 43, 709, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 12, 37, 43, 710, DateTimeKind.Utc).AddTicks(4152));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "d1634242-1edd-4865-a4cf-cd70dcf6ff6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55212e65-8569-5ad7-b12a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "dd88c500-4aa4-48fc-9b9d-becde418d907");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a05bd244-c09c-4052-9b7d-91d6f02ba998", "AQAAAAEAACcQAAAAEBql/eAHLjzawJNbouiPXDTKs5P0XzAxlt06jFQNwbZRYaHWoPrfNe1lQvyM540RPA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b62452e-4f66-49fa-a20f-e7521b1355d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5205b88-0699-4579-be95-5e9be2bd0937", "AQAAAAEAACcQAAAAEPMFa5lY4yqkaXNGewEJUT8RAaYVvIpE6ceHlN3xr8ON06/YoGZuRBnbqITXREA6ow==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 12, 30, 42, 803, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 12, 30, 42, 803, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 12, 30, 42, 803, DateTimeKind.Utc).AddTicks(9800));
        }
    }
}
