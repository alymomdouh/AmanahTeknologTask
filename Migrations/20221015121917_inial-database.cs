﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmanahTeknologTask.Migrations
{
    public partial class inialdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyClients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndividualClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualClients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndividualClientId = table.Column<int>(type: "int", nullable: true),
                    CompanyClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankInformation_CompanyClients_CompanyClientId",
                        column: x => x.CompanyClientId,
                        principalTable: "CompanyClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankInformation_IndividualClients_IndividualClientId",
                        column: x => x.IndividualClientId,
                        principalTable: "IndividualClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CardInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    expireDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndividualClientId = table.Column<int>(type: "int", nullable: true),
                    CompanyClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardInformation_CompanyClients_CompanyClientId",
                        column: x => x.CompanyClientId,
                        principalTable: "CompanyClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CardInformation_IndividualClients_IndividualClientId",
                        column: x => x.IndividualClientId,
                        principalTable: "IndividualClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payway",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CardInformationId = table.Column<int>(type: "int", nullable: false),
                    BankInformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payway", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payway_BankInformation_BankInformationId",
                        column: x => x.BankInformationId,
                        principalTable: "BankInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payway_CardInformation_CardInformationId",
                        column: x => x.CardInformationId,
                        principalTable: "CardInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Totalprice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IndividualClientId = table.Column<int>(type: "int", nullable: true),
                    CompanyClientId = table.Column<int>(type: "int", nullable: true),
                    PaywayId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_CompanyClients_CompanyClientId",
                        column: x => x.CompanyClientId,
                        principalTable: "CompanyClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_IndividualClients_IndividualClientId",
                        column: x => x.IndividualClientId,
                        principalTable: "IndividualClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Payway_PaywayId",
                        column: x => x.PaywayId,
                        principalTable: "Payway",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CompanyClients",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 1, "CompanyClient1@gmail.com", "CompanyClient1" });

            migrationBuilder.InsertData(
                table: "IndividualClients",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 1, "IndividualClient1@gmail.com", "IndividualClient1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Product1", 10 },
                    { 2, "Product2", 20 },
                    { 3, "Product3", 30 },
                    { 4, "Product4", 40 },
                    { 5, "Product5", 50 },
                    { 6, "Product6", 60 }
                });

            migrationBuilder.InsertData(
                table: "Taxes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 1, "John Doe", 30m });

            migrationBuilder.CreateIndex(
                name: "IX_BankInformation_CompanyClientId",
                table: "BankInformation",
                column: "CompanyClientId");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformation_IndividualClientId",
                table: "BankInformation",
                column: "IndividualClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CardInformation_CompanyClientId",
                table: "CardInformation",
                column: "CompanyClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CardInformation_IndividualClientId",
                table: "CardInformation",
                column: "IndividualClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CompanyClientId",
                table: "Invoices",
                column: "CompanyClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_IndividualClientId",
                table: "Invoices",
                column: "IndividualClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_PaywayId",
                table: "Invoices",
                column: "PaywayId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ProductId",
                table: "Invoices",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_TaxId",
                table: "Invoices",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Payway_BankInformationId",
                table: "Payway",
                column: "BankInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Payway_CardInformationId",
                table: "Payway",
                column: "CardInformationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Payway");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "BankInformation");

            migrationBuilder.DropTable(
                name: "CardInformation");

            migrationBuilder.DropTable(
                name: "CompanyClients");

            migrationBuilder.DropTable(
                name: "IndividualClients");
        }
    }
}
