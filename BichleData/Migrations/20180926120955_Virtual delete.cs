using Microsoft.EntityFrameworkCore.Migrations;

namespace BichleData.Migrations
{
    public partial class Virtualdelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryBranches_LibraryBranchId",
                table: "CheckoutHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_LibraryBranches_LibraryBranchId",
                table: "Checkouts");

            migrationBuilder.DropIndex(
                name: "IX_Checkouts_LibraryBranchId",
                table: "Checkouts");

            migrationBuilder.DropColumn(
                name: "LibraryBranchId",
                table: "Checkouts");

            migrationBuilder.RenameColumn(
                name: "LibraryBranchId",
                table: "CheckoutHistories",
                newName: "LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistories_LibraryBranchId",
                table: "CheckoutHistories",
                newName: "IX_CheckoutHistories_LibraryCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryCards_LibraryCardId",
                table: "CheckoutHistories",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryCards_LibraryCardId",
                table: "CheckoutHistories");

            migrationBuilder.RenameColumn(
                name: "LibraryCardId",
                table: "CheckoutHistories",
                newName: "LibraryBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistories_LibraryCardId",
                table: "CheckoutHistories",
                newName: "IX_CheckoutHistories_LibraryBranchId");

            migrationBuilder.AddColumn<int>(
                name: "LibraryBranchId",
                table: "Checkouts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_LibraryBranchId",
                table: "Checkouts",
                column: "LibraryBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryBranches_LibraryBranchId",
                table: "CheckoutHistories",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_LibraryBranches_LibraryBranchId",
                table: "Checkouts",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
