using Microsoft.EntityFrameworkCore.Migrations;

namespace PROG2230_JisungKim.Migrations
{
    public partial class company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TickerSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    TransactionTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommissionFee = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.TransactionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionRecords",
                columns: table => new
                {
                    TransactionRecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SharePrice = table.Column<double>(type: "float", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionRecords", x => x.TransactionRecordId);
                    table.ForeignKey(
                        name: "FK_TransactionRecords_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionRecords_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "TransactionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Name", "TickerSymbol" },
                values: new object[,]
                {
                    { 1, "123 Google Way", "Google", "GOOG" },
                    { 2, "453 Bill Gates Drive", "Microsoft", "MSFT" }
                });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "TransactionTypeId", "CommissionFee", "Name" },
                values: new object[,]
                {
                    { 1, 5.4000000000000004, "Buy" },
                    { 2, 5.9900000000000002, "Sell" }
                });

            migrationBuilder.InsertData(
                table: "TransactionRecords",
                columns: new[] { "TransactionRecordId", "CompanyId", "Quantity", "SharePrice", "TransactionTypeId" },
                values: new object[] { 1, 1, 100, 123.45, 1 });

            migrationBuilder.InsertData(
                table: "TransactionRecords",
                columns: new[] { "TransactionRecordId", "CompanyId", "Quantity", "SharePrice", "TransactionTypeId" },
                values: new object[] { 2, 2, 100, 2701.7600000000002, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRecords_CompanyId",
                table: "TransactionRecords",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRecords_TransactionTypeId",
                table: "TransactionRecords",
                column: "TransactionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionRecords");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "TransactionTypes");
        }
    }
}
