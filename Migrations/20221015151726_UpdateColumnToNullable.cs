using Microsoft.EntityFrameworkCore.Migrations;

namespace AmanahTeknologTask.Migrations
{
    public partial class UpdateColumnToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Taxes_TaxId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Payway_BankInformation_BankInformationId",
                table: "Payway");

            migrationBuilder.DropForeignKey(
                name: "FK_Payway_CardInformation_CardInformationId",
                table: "Payway");

            migrationBuilder.AlterColumn<int>(
                name: "CardInformationId",
                table: "Payway",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BankInformationId",
                table: "Payway",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TaxId",
                table: "Invoices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Taxes_TaxId",
                table: "Invoices",
                column: "TaxId",
                principalTable: "Taxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payway_BankInformation_BankInformationId",
                table: "Payway",
                column: "BankInformationId",
                principalTable: "BankInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payway_CardInformation_CardInformationId",
                table: "Payway",
                column: "CardInformationId",
                principalTable: "CardInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Taxes_TaxId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Payway_BankInformation_BankInformationId",
                table: "Payway");

            migrationBuilder.DropForeignKey(
                name: "FK_Payway_CardInformation_CardInformationId",
                table: "Payway");

            migrationBuilder.AlterColumn<int>(
                name: "CardInformationId",
                table: "Payway",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BankInformationId",
                table: "Payway",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaxId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Taxes_TaxId",
                table: "Invoices",
                column: "TaxId",
                principalTable: "Taxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payway_BankInformation_BankInformationId",
                table: "Payway",
                column: "BankInformationId",
                principalTable: "BankInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payway_CardInformation_CardInformationId",
                table: "Payway",
                column: "CardInformationId",
                principalTable: "CardInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
