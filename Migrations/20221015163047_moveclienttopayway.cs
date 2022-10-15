using Microsoft.EntityFrameworkCore.Migrations;

namespace AmanahTeknologTask.Migrations
{
    public partial class moveclienttopayway : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankInformation_CompanyClients_CompanyClientId",
                table: "BankInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_BankInformation_IndividualClients_IndividualClientId",
                table: "BankInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_CardInformation_CompanyClients_CompanyClientId",
                table: "CardInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_CardInformation_IndividualClients_IndividualClientId",
                table: "CardInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Payway_PaywayId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_CardInformation_CompanyClientId",
                table: "CardInformation");

            migrationBuilder.DropIndex(
                name: "IX_CardInformation_IndividualClientId",
                table: "CardInformation");

            migrationBuilder.DropIndex(
                name: "IX_BankInformation_CompanyClientId",
                table: "BankInformation");

            migrationBuilder.DropIndex(
                name: "IX_BankInformation_IndividualClientId",
                table: "BankInformation");

            migrationBuilder.AddColumn<int>(
                name: "CompanyClientId",
                table: "Payway",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndividualClientId",
                table: "Payway",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaywayId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payway_CompanyClientId",
                table: "Payway",
                column: "CompanyClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Payway_IndividualClientId",
                table: "Payway",
                column: "IndividualClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Payway_PaywayId",
                table: "Invoices",
                column: "PaywayId",
                principalTable: "Payway",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payway_CompanyClients_CompanyClientId",
                table: "Payway",
                column: "CompanyClientId",
                principalTable: "CompanyClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payway_IndividualClients_IndividualClientId",
                table: "Payway",
                column: "IndividualClientId",
                principalTable: "IndividualClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Payway_PaywayId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Payway_CompanyClients_CompanyClientId",
                table: "Payway");

            migrationBuilder.DropForeignKey(
                name: "FK_Payway_IndividualClients_IndividualClientId",
                table: "Payway");

            migrationBuilder.DropIndex(
                name: "IX_Payway_CompanyClientId",
                table: "Payway");

            migrationBuilder.DropIndex(
                name: "IX_Payway_IndividualClientId",
                table: "Payway");

            migrationBuilder.DropColumn(
                name: "CompanyClientId",
                table: "Payway");

            migrationBuilder.DropColumn(
                name: "IndividualClientId",
                table: "Payway");

            migrationBuilder.AlterColumn<int>(
                name: "PaywayId",
                table: "Invoices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CardInformation_CompanyClientId",
                table: "CardInformation",
                column: "CompanyClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CardInformation_IndividualClientId",
                table: "CardInformation",
                column: "IndividualClientId");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformation_CompanyClientId",
                table: "BankInformation",
                column: "CompanyClientId");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformation_IndividualClientId",
                table: "BankInformation",
                column: "IndividualClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankInformation_CompanyClients_CompanyClientId",
                table: "BankInformation",
                column: "CompanyClientId",
                principalTable: "CompanyClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BankInformation_IndividualClients_IndividualClientId",
                table: "BankInformation",
                column: "IndividualClientId",
                principalTable: "IndividualClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CardInformation_CompanyClients_CompanyClientId",
                table: "CardInformation",
                column: "CompanyClientId",
                principalTable: "CompanyClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CardInformation_IndividualClients_IndividualClientId",
                table: "CardInformation",
                column: "IndividualClientId",
                principalTable: "IndividualClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Payway_PaywayId",
                table: "Invoices",
                column: "PaywayId",
                principalTable: "Payway",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
