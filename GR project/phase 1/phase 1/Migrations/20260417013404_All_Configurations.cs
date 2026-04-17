using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace phase_1.Migrations
{
    /// <inheritdoc />
    public partial class All_Configurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_LocationAreas_AreaId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_ServiceTypes_ServiceTypeId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_TreatmentCategories_TreatmentCategoryId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_SenderUserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_OtpCodes_Users_UserId",
                table: "OtpCodes");

            migrationBuilder.DropIndex(
                name: "IX_Offers_StudentUserId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Matches_CaseId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Cases_PatientUserId",
                table: "Cases");

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfiles_IsVerified",
                table: "StudentProfiles",
                column: "IsVerified");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Review_Rating",
                table: "Reviews",
                sql: "[Rating] >= 1 AND [Rating] <= 5");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_TargetType_TargetId",
                table: "Reports",
                columns: new[] { "TargetType", "TargetId" });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_StudentUserId_Status_CreatedAt",
                table: "Offers",
                columns: new[] { "StudentUserId", "Status", "CreatedAt" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_CaseId",
                table: "Matches",
                column: "CaseId",
                unique: true,
                filter: "[Status] IN (1, 2)");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_PatientUserId_Status_CreatedAt",
                table: "Cases",
                columns: new[] { "PatientUserId", "Status", "CreatedAt" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_LocationAreas_AreaId",
                table: "Cases",
                column: "AreaId",
                principalTable: "LocationAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_ServiceTypes_ServiceTypeId",
                table: "Cases",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_TreatmentCategories_TreatmentCategoryId",
                table: "Cases",
                column: "TreatmentCategoryId",
                principalTable: "TreatmentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_SenderUserId",
                table: "Messages",
                column: "SenderUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtpCodes_Users_UserId",
                table: "OtpCodes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_LocationAreas_AreaId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_ServiceTypes_ServiceTypeId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_TreatmentCategories_TreatmentCategoryId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_SenderUserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_OtpCodes_Users_UserId",
                table: "OtpCodes");

            migrationBuilder.DropIndex(
                name: "IX_StudentProfiles_IsVerified",
                table: "StudentProfiles");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Review_Rating",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reports_TargetType_TargetId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Offers_StudentUserId_Status_CreatedAt",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Matches_CaseId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Cases_PatientUserId_Status_CreatedAt",
                table: "Cases");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_StudentUserId",
                table: "Offers",
                column: "StudentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_CaseId",
                table: "Matches",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_PatientUserId",
                table: "Cases",
                column: "PatientUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_LocationAreas_AreaId",
                table: "Cases",
                column: "AreaId",
                principalTable: "LocationAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_ServiceTypes_ServiceTypeId",
                table: "Cases",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_TreatmentCategories_TreatmentCategoryId",
                table: "Cases",
                column: "TreatmentCategoryId",
                principalTable: "TreatmentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_SenderUserId",
                table: "Messages",
                column: "SenderUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OtpCodes_Users_UserId",
                table: "OtpCodes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
