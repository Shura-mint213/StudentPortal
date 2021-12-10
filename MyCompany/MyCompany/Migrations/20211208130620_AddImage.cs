using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class AddImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "762b64de-982c-4447-b714-0b84cd381c66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55212e65-8569-5ad7-b12a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "1ad60ed4-1445-442a-89ef-94594f9851a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9231bdab-821d-4806-aa84-7cf7feaa5b37", "AQAAAAEAACcQAAAAEJqXdmR2gclZI/l83i4FEVyO9IgyBr54UY+n5WhrLJ+ikmEoroxw9lmzN5mgJGGnCA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b62452e-4f66-49fa-a20f-e7521b1355d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eae4715d-4c19-4755-8fa5-47829fd1da3f", "AQAAAAEAACcQAAAAEH8F/h0LeqIS2MWGIroDOUUAa2++phahIG7if+5hQZKhyTsPpG5PmGCftwbcMq+WbQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 8, 13, 6, 18, 931, DateTimeKind.Utc).AddTicks(9231), "Содержание заполняется администратором" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 8, 13, 6, 18, 931, DateTimeKind.Utc).AddTicks(6182), "Содержание заполняется администратором" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 8, 13, 6, 18, 931, DateTimeKind.Utc).AddTicks(8939), "Содержание заполняется администратором" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 8, 12, 37, 43, 710, DateTimeKind.Utc).AddTicks(4874), null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 8, 12, 37, 43, 709, DateTimeKind.Utc).AddTicks(5173), null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "DateAdded", "TitleImagePath" },
                values: new object[] { new DateTime(2021, 12, 8, 12, 37, 43, 710, DateTimeKind.Utc).AddTicks(4152), null });
        }
    }
}
