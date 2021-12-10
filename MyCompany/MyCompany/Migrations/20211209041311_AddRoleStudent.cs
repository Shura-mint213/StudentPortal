using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class AddRoleStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "5b62452e-4f66-49fa-a20f-e7521b1355d8", "55212e65-8569-5ad7-b12a-f271ae9d6eab" });

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
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 4, 13, 9, 4, DateTimeKind.Utc).AddTicks(658));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5b62452e-4f66-49fa-a20f-e7521b1355d8", "55212e65-8569-5ad7-b12a-f271ae9d6eab" });

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
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 13, 6, 18, 931, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 13, 6, 18, 931, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 8, 13, 6, 18, 931, DateTimeKind.Utc).AddTicks(8939));
        }
    }
}
