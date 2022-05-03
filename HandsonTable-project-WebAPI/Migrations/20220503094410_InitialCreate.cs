using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandsonTable_project_WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HandsontableDataModels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    skill1 = table.Column<double>(type: "float", nullable: false),
                    skill2 = table.Column<double>(type: "float", nullable: false),
                    skill3 = table.Column<double>(type: "float", nullable: false),
                    capacity1 = table.Column<double>(type: "float", nullable: false),
                    capacity2 = table.Column<double>(type: "float", nullable: false),
                    capacity3 = table.Column<double>(type: "float", nullable: false),
                    capacity4 = table.Column<double>(type: "float", nullable: false),
                    rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandsontableDataModels", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "HandsontableDataModels",
                columns: new[] { "id", "capacity1", "capacity2", "capacity3", "capacity4", "rate", "skill1", "skill2", "skill3", "unit" },
                values: new object[,]
                {
                    { 1, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "A" },
                    { 2, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "B" },
                    { 3, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "C" },
                    { 4, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "D" },
                    { 5, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.40000000000000002, 0.29999999999999999, "E" },
                    { 6, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.40000000000000002, "F" },
                    { 7, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "G" },
                    { 8, 0.29999999999999999, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.29999999999999999, "H" },
                    { 9, 0.40000000000000002, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.40000000000000002, 0.20000000000000001, 0.40000000000000002, "I" },
                    { 10, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.20000000000000001, 0.5, 0.5, 0.20000000000000001, 0.29999999999999999, "J" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HandsontableDataModels");
        }
    }
}
