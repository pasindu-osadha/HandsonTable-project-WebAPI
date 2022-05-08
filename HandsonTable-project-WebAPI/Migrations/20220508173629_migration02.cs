using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandsonTable_project_WebAPI.Migrations
{
    public partial class migration02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HandsontableDataModels",
                columns: new[] { "id", "capacity1", "capacity2", "capacity3", "capacity4", "rate", "skill1", "skill2", "skill3", "unit" },
                values: new object[,]
                {
                    { 11, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "k" },
                    { 12, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "L" },
                    { 13, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "M" },
                    { 14, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "N" },
                    { 15, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "O" },
                    { 16, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "P" },
                    { 17, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "Q" },
                    { 18, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "R" },
                    { 19, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.40000000000000002, "S" },
                    { 20, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "T" },
                    { 21, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "AA" },
                    { 22, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "BA" },
                    { 23, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "CA" },
                    { 24, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "DA" },
                    { 25, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "EA" },
                    { 26, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "FA" },
                    { 27, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "GA" },
                    { 28, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "HA" },
                    { 29, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.40000000000000002, "IA" },
                    { 30, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "JA" },
                    { 31, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "kA" },
                    { 32, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "LA" },
                    { 33, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "MA" },
                    { 34, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "NA" },
                    { 35, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "OA" },
                    { 36, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "PA" },
                    { 37, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "QA" },
                    { 38, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "RA" },
                    { 39, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.40000000000000002, "SA" },
                    { 40, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "TA" },
                    { 41, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "AB" },
                    { 42, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "BB" },
                    { 43, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "CB" },
                    { 44, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "DB" },
                    { 45, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "EB" },
                    { 46, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "FB" },
                    { 47, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "GB" },
                    { 48, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "HB" },
                    { 49, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.40000000000000002, "IB" },
                    { 50, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "JB" },
                    { 51, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "kB" },
                    { 52, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "LB" }
                });

            migrationBuilder.InsertData(
                table: "HandsontableDataModels",
                columns: new[] { "id", "capacity1", "capacity2", "capacity3", "capacity4", "rate", "skill1", "skill2", "skill3", "unit" },
                values: new object[,]
                {
                    { 53, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "MB" },
                    { 54, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "NB" },
                    { 55, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "OB" },
                    { 56, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "PB" },
                    { 57, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "QB" },
                    { 58, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "RB" },
                    { 59, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.40000000000000002, "SB" },
                    { 60, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "TB" },
                    { 61, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "AAB" },
                    { 62, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "BAB" },
                    { 63, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "CAB" },
                    { 64, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "DAB" },
                    { 65, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "EAB" },
                    { 66, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "FAB" },
                    { 67, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "GAB" },
                    { 68, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "HAB" },
                    { 69, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.40000000000000002, "IAB" },
                    { 70, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "JAB" },
                    { 71, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "kAB" },
                    { 72, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "LAB" },
                    { 73, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "MAB" },
                    { 74, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "NAB" },
                    { 75, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "OAB" },
                    { 76, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "PAB" },
                    { 77, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "QAB" },
                    { 78, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "RAB" },
                    { 79, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.40000000000000002, "SAB" },
                    { 80, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "TAB" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "HandsontableDataModels",
                keyColumn: "id",
                keyValue: 80);
        }
    }
}
