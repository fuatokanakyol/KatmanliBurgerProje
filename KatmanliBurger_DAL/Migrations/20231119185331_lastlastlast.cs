using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatmanliBurger_DAL.Migrations
{
    public partial class lastlastlast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 53, 31, 465, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 53, 31, 465, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 53, 31, 465, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 53, 31, 465, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 53, 31, 465, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 53, 31, 465, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 53, 31, 465, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 53, 31, 465, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 53, 31, 465, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 53, 31, 465, DateTimeKind.Local).AddTicks(7923));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 42, 38, 755, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 42, 38, 755, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 42, 38, 755, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 42, 38, 755, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 42, 38, 755, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 42, 38, 755, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 42, 38, 755, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 42, 38, 755, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 42, 38, 755, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "ParameterTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 19, 21, 42, 38, 755, DateTimeKind.Local).AddTicks(5673));
        }
    }
}
