using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class AddPageSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 3, 13, 44, 686, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 10, 3, 13, 44, 685, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2021, 12, 10, 3, 13, 44, 686, DateTimeKind.Utc).AddTicks(7589), "Наши новости" });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("5aa21a4c-c16d-932a-14c1-06e6487a643a"), "PageSchedule", new DateTime(2021, 12, 10, 3, 13, 44, 686, DateTimeKind.Utc).AddTicks(8481), null, null, null, null, "Содержание заполняется администратором", "Расписание", "Содержание заполняется администратором" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5aa21a4c-c16d-932a-14c1-06e6487a643a"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "03a1c3a3-f29c-4e42-9064-06f6c34e0ae0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55212e65-8569-5ad7-b12a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "c50113df-19e5-4196-8b40-f28039ba4e23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7335fcbf-472e-44d2-afb4-c56e68b9865a", "AQAAAAEAACcQAAAAEAw8iR0rqsfmh+hb2s3mvmexj7UGXrB6aGFGBnSDd+QXNSihkX5keC5yWDe+8Ztelw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b62452e-4f66-49fa-a20f-e7521b1355d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5cb9cf0f-05a6-4794-8c48-f37436845e7b", "AQAAAAEAACcQAAAAEFzryzk0X+16XYrBg10YNGTwtBH0kRw3ZtUktFTZDnp66CvKpU4h3L/pIJZaKqTNig==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 4, 13, 9, 4, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 4, 13, 9, 2, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2021, 12, 9, 4, 13, 9, 4, DateTimeKind.Utc).AddTicks(658), "Наши услуги" });
        }
    }
}
