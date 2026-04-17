using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace phase_1.Migrations
{
    /// <inheritdoc />
    public partial class PostConfigCleanup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NoShowStrikes_Users_UserId",
                table: "NoShowStrikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Cases_CaseId",
                table: "Offers");

            migrationBuilder.AddForeignKey(
                name: "FK_NoShowStrikes_Users_UserId",
                table: "NoShowStrikes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Cases_CaseId",
                table: "Offers",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NoShowStrikes_Users_UserId",
                table: "NoShowStrikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Cases_CaseId",
                table: "Offers");

            migrationBuilder.AddForeignKey(
                name: "FK_NoShowStrikes_Users_UserId",
                table: "NoShowStrikes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Cases_CaseId",
                table: "Offers",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
