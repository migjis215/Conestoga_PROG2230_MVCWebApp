﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PROG2230_JisungKim.Migrations
{
    public partial class type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionTypeId",
                table: "TransactionRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "TransactionTypeId", "CommissionFee", "Name" },
                values: new object[] { 1, 5.4000000000000004, "Buy" });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "TransactionTypeId", "CommissionFee", "Name" },
                values: new object[] { 2, 5.9900000000000002, "Sell" });

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 1,
                column: "TransactionTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 2,
                column: "TransactionTypeId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRecords_TransactionTypeId",
                table: "TransactionRecords",
                column: "TransactionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionRecords_TransactionTypes_TransactionTypeId",
                table: "TransactionRecords",
                column: "TransactionTypeId",
                principalTable: "TransactionTypes",
                principalColumn: "TransactionTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionRecords_TransactionTypes_TransactionTypeId",
                table: "TransactionRecords");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropIndex(
                name: "IX_TransactionRecords_TransactionTypeId",
                table: "TransactionRecords");

            migrationBuilder.DropColumn(
                name: "TransactionTypeId",
                table: "TransactionRecords");
        }
    }
}
