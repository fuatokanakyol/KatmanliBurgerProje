using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatmanliBurger_DAL.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 36, 18, 545, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 36, 18, 545, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 36, 18, 545, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 36, 18, 545, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 36, 18, 545, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 36, 18, 545, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 36, 18, 545, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 36, 18, 545, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 36, 18, 545, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 14, 36, 18, 545, DateTimeKind.Local).AddTicks(5808));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 0, 18, 5, 111, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 0, 18, 5, 111, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 0, 18, 5, 111, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 0, 18, 5, 111, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 0, 18, 5, 111, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 0, 18, 5, 111, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 0, 18, 5, 111, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 0, 18, 5, 111, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 0, 18, 5, 111, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 0, 18, 5, 111, DateTimeKind.Local).AddTicks(5579));
        }
    }
}
