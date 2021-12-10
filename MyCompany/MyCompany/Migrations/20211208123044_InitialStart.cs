using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class InitialStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "d1634242-1edd-4865-a4cf-cd70dcf6ff6c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "55212e65-8569-5ad7-b12a-f271ae9d6eab", "dd88c500-4aa4-48fc-9b9d-becde418d907", "student", "STUDENT" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a05bd244-c09c-4052-9b7d-91d6f02ba998", "AQAAAAEAACcQAAAAEBql/eAHLjzawJNbouiPXDTKs5P0XzAxlt06jFQNwbZRYaHWoPrfNe1lQvyM540RPA==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5b62452e-4f66-49fa-a20f-e7521b1355d8", 0, "f5205b88-0699-4579-be95-5e9be2bd0937", "myStudent@email.com", true, false, null, "MYSTUDENT@EMAIL.COM", "STUDENT", "AQAAAAEAACcQAAAAEPMFa5lY4yqkaXNGewEJUT8RAaYVvIpE6ceHlN3xr8ON06/YoGZuRBnbqITXREA6ow==", null, false, "", false, "student" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55212e65-8569-5ad7-b12a-f271ae9d6eab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b62452e-4f66-49fa-a20f-e7521b1355d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "ad752618-d870-46dd-8547-00a0083621a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5189d2c6-fdc3-4d95-9dff-2327896ec443", "AQAAAAEAACcQAAAAENydi4RzCP9UWgaixQCaTsR0fyUhOW8abwt6c7nCoYz4k2+V3GUyJEZuwxfpm0ZhQw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 11, 33, 48, 933, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 11, 33, 48, 932, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 11, 33, 48, 933, DateTimeKind.Utc).AddTicks(1759));
        }
    }
}
