using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamAssignmentApi.Migrations
{
    /// <inheritdoc />
    public partial class Add100DocumentRequestsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DocumentRequests",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedByUserId", "Remarks", "Status", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "This is the detailed content description for document request number 1 used for pagination testing.", new DateTime(2026, 1, 1, 1, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 1", null },
                    { 2, "This is the detailed content description for document request number 2 used for pagination testing.", new DateTime(2026, 1, 1, 2, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 2", null },
                    { 3, "This is the detailed content description for document request number 3 used for pagination testing.", new DateTime(2026, 1, 1, 3, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 3", null },
                    { 4, "This is the detailed content description for document request number 4 used for pagination testing.", new DateTime(2026, 1, 1, 4, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 4", null },
                    { 5, "This is the detailed content description for document request number 5 used for pagination testing.", new DateTime(2026, 1, 1, 5, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 5", null },
                    { 6, "This is the detailed content description for document request number 6 used for pagination testing.", new DateTime(2026, 1, 1, 6, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 6", null },
                    { 7, "This is the detailed content description for document request number 7 used for pagination testing.", new DateTime(2026, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 7", null },
                    { 8, "This is the detailed content description for document request number 8 used for pagination testing.", new DateTime(2026, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 8", null },
                    { 9, "This is the detailed content description for document request number 9 used for pagination testing.", new DateTime(2026, 1, 1, 9, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 9", null },
                    { 10, "This is the detailed content description for document request number 10 used for pagination testing.", new DateTime(2026, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 10", null },
                    { 11, "This is the detailed content description for document request number 11 used for pagination testing.", new DateTime(2026, 1, 1, 11, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 11", null },
                    { 12, "This is the detailed content description for document request number 12 used for pagination testing.", new DateTime(2026, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 12", null },
                    { 13, "This is the detailed content description for document request number 13 used for pagination testing.", new DateTime(2026, 1, 1, 13, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 13", null },
                    { 14, "This is the detailed content description for document request number 14 used for pagination testing.", new DateTime(2026, 1, 1, 14, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 14", null },
                    { 15, "This is the detailed content description for document request number 15 used for pagination testing.", new DateTime(2026, 1, 1, 15, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 15", null },
                    { 16, "This is the detailed content description for document request number 16 used for pagination testing.", new DateTime(2026, 1, 1, 16, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 16", null },
                    { 17, "This is the detailed content description for document request number 17 used for pagination testing.", new DateTime(2026, 1, 1, 17, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 17", null },
                    { 18, "This is the detailed content description for document request number 18 used for pagination testing.", new DateTime(2026, 1, 1, 18, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 18", null },
                    { 19, "This is the detailed content description for document request number 19 used for pagination testing.", new DateTime(2026, 1, 1, 19, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 19", null },
                    { 20, "This is the detailed content description for document request number 20 used for pagination testing.", new DateTime(2026, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 20", null },
                    { 21, "This is the detailed content description for document request number 21 used for pagination testing.", new DateTime(2026, 1, 1, 21, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 21", null },
                    { 22, "This is the detailed content description for document request number 22 used for pagination testing.", new DateTime(2026, 1, 1, 22, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 22", null },
                    { 23, "This is the detailed content description for document request number 23 used for pagination testing.", new DateTime(2026, 1, 1, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 23", null },
                    { 24, "This is the detailed content description for document request number 24 used for pagination testing.", new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 24", null },
                    { 25, "This is the detailed content description for document request number 25 used for pagination testing.", new DateTime(2026, 1, 2, 1, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 25", null },
                    { 26, "This is the detailed content description for document request number 26 used for pagination testing.", new DateTime(2026, 1, 2, 2, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 26", null },
                    { 27, "This is the detailed content description for document request number 27 used for pagination testing.", new DateTime(2026, 1, 2, 3, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 27", null },
                    { 28, "This is the detailed content description for document request number 28 used for pagination testing.", new DateTime(2026, 1, 2, 4, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 28", null },
                    { 29, "This is the detailed content description for document request number 29 used for pagination testing.", new DateTime(2026, 1, 2, 5, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 29", null },
                    { 30, "This is the detailed content description for document request number 30 used for pagination testing.", new DateTime(2026, 1, 2, 6, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 30", null },
                    { 31, "This is the detailed content description for document request number 31 used for pagination testing.", new DateTime(2026, 1, 2, 7, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 31", null },
                    { 32, "This is the detailed content description for document request number 32 used for pagination testing.", new DateTime(2026, 1, 2, 8, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 32", null },
                    { 33, "This is the detailed content description for document request number 33 used for pagination testing.", new DateTime(2026, 1, 2, 9, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 33", null },
                    { 34, "This is the detailed content description for document request number 34 used for pagination testing.", new DateTime(2026, 1, 2, 10, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 34", null },
                    { 35, "This is the detailed content description for document request number 35 used for pagination testing.", new DateTime(2026, 1, 2, 11, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 35", null },
                    { 36, "This is the detailed content description for document request number 36 used for pagination testing.", new DateTime(2026, 1, 2, 12, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 36", null },
                    { 37, "This is the detailed content description for document request number 37 used for pagination testing.", new DateTime(2026, 1, 2, 13, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 37", null },
                    { 38, "This is the detailed content description for document request number 38 used for pagination testing.", new DateTime(2026, 1, 2, 14, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 38", null },
                    { 39, "This is the detailed content description for document request number 39 used for pagination testing.", new DateTime(2026, 1, 2, 15, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 39", null },
                    { 40, "This is the detailed content description for document request number 40 used for pagination testing.", new DateTime(2026, 1, 2, 16, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 40", null },
                    { 41, "This is the detailed content description for document request number 41 used for pagination testing.", new DateTime(2026, 1, 2, 17, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 41", null },
                    { 42, "This is the detailed content description for document request number 42 used for pagination testing.", new DateTime(2026, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 42", null },
                    { 43, "This is the detailed content description for document request number 43 used for pagination testing.", new DateTime(2026, 1, 2, 19, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 43", null },
                    { 44, "This is the detailed content description for document request number 44 used for pagination testing.", new DateTime(2026, 1, 2, 20, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 44", null },
                    { 45, "This is the detailed content description for document request number 45 used for pagination testing.", new DateTime(2026, 1, 2, 21, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 45", null },
                    { 46, "This is the detailed content description for document request number 46 used for pagination testing.", new DateTime(2026, 1, 2, 22, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 46", null },
                    { 47, "This is the detailed content description for document request number 47 used for pagination testing.", new DateTime(2026, 1, 2, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 47", null },
                    { 48, "This is the detailed content description for document request number 48 used for pagination testing.", new DateTime(2026, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 48", null },
                    { 49, "This is the detailed content description for document request number 49 used for pagination testing.", new DateTime(2026, 1, 3, 1, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 49", null },
                    { 50, "This is the detailed content description for document request number 50 used for pagination testing.", new DateTime(2026, 1, 3, 2, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 50", null },
                    { 51, "This is the detailed content description for document request number 51 used for pagination testing.", new DateTime(2026, 1, 3, 3, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 51", null },
                    { 52, "This is the detailed content description for document request number 52 used for pagination testing.", new DateTime(2026, 1, 3, 4, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 52", null },
                    { 53, "This is the detailed content description for document request number 53 used for pagination testing.", new DateTime(2026, 1, 3, 5, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 53", null },
                    { 54, "This is the detailed content description for document request number 54 used for pagination testing.", new DateTime(2026, 1, 3, 6, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 54", null },
                    { 55, "This is the detailed content description for document request number 55 used for pagination testing.", new DateTime(2026, 1, 3, 7, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 55", null },
                    { 56, "This is the detailed content description for document request number 56 used for pagination testing.", new DateTime(2026, 1, 3, 8, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 56", null },
                    { 57, "This is the detailed content description for document request number 57 used for pagination testing.", new DateTime(2026, 1, 3, 9, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 57", null },
                    { 58, "This is the detailed content description for document request number 58 used for pagination testing.", new DateTime(2026, 1, 3, 10, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 58", null },
                    { 59, "This is the detailed content description for document request number 59 used for pagination testing.", new DateTime(2026, 1, 3, 11, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 59", null },
                    { 60, "This is the detailed content description for document request number 60 used for pagination testing.", new DateTime(2026, 1, 3, 12, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 60", null },
                    { 61, "This is the detailed content description for document request number 61 used for pagination testing.", new DateTime(2026, 1, 3, 13, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 61", null },
                    { 62, "This is the detailed content description for document request number 62 used for pagination testing.", new DateTime(2026, 1, 3, 14, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 62", null },
                    { 63, "This is the detailed content description for document request number 63 used for pagination testing.", new DateTime(2026, 1, 3, 15, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 63", null },
                    { 64, "This is the detailed content description for document request number 64 used for pagination testing.", new DateTime(2026, 1, 3, 16, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 64", null },
                    { 65, "This is the detailed content description for document request number 65 used for pagination testing.", new DateTime(2026, 1, 3, 17, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 65", null },
                    { 66, "This is the detailed content description for document request number 66 used for pagination testing.", new DateTime(2026, 1, 3, 18, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 66", null },
                    { 67, "This is the detailed content description for document request number 67 used for pagination testing.", new DateTime(2026, 1, 3, 19, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 67", null },
                    { 68, "This is the detailed content description for document request number 68 used for pagination testing.", new DateTime(2026, 1, 3, 20, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 68", null },
                    { 69, "This is the detailed content description for document request number 69 used for pagination testing.", new DateTime(2026, 1, 3, 21, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 69", null },
                    { 70, "This is the detailed content description for document request number 70 used for pagination testing.", new DateTime(2026, 1, 3, 22, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 70", null },
                    { 71, "This is the detailed content description for document request number 71 used for pagination testing.", new DateTime(2026, 1, 3, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 71", null },
                    { 72, "This is the detailed content description for document request number 72 used for pagination testing.", new DateTime(2026, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 72", null },
                    { 73, "This is the detailed content description for document request number 73 used for pagination testing.", new DateTime(2026, 1, 4, 1, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 73", null },
                    { 74, "This is the detailed content description for document request number 74 used for pagination testing.", new DateTime(2026, 1, 4, 2, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 74", null },
                    { 75, "This is the detailed content description for document request number 75 used for pagination testing.", new DateTime(2026, 1, 4, 3, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 75", null },
                    { 76, "This is the detailed content description for document request number 76 used for pagination testing.", new DateTime(2026, 1, 4, 4, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 76", null },
                    { 77, "This is the detailed content description for document request number 77 used for pagination testing.", new DateTime(2026, 1, 4, 5, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 77", null },
                    { 78, "This is the detailed content description for document request number 78 used for pagination testing.", new DateTime(2026, 1, 4, 6, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 78", null },
                    { 79, "This is the detailed content description for document request number 79 used for pagination testing.", new DateTime(2026, 1, 4, 7, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 79", null },
                    { 80, "This is the detailed content description for document request number 80 used for pagination testing.", new DateTime(2026, 1, 4, 8, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 80", null },
                    { 81, "This is the detailed content description for document request number 81 used for pagination testing.", new DateTime(2026, 1, 4, 9, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 81", null },
                    { 82, "This is the detailed content description for document request number 82 used for pagination testing.", new DateTime(2026, 1, 4, 10, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 82", null },
                    { 83, "This is the detailed content description for document request number 83 used for pagination testing.", new DateTime(2026, 1, 4, 11, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 83", null },
                    { 84, "This is the detailed content description for document request number 84 used for pagination testing.", new DateTime(2026, 1, 4, 12, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 84", null },
                    { 85, "This is the detailed content description for document request number 85 used for pagination testing.", new DateTime(2026, 1, 4, 13, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 85", null },
                    { 86, "This is the detailed content description for document request number 86 used for pagination testing.", new DateTime(2026, 1, 4, 14, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 86", null },
                    { 87, "This is the detailed content description for document request number 87 used for pagination testing.", new DateTime(2026, 1, 4, 15, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 87", null },
                    { 88, "This is the detailed content description for document request number 88 used for pagination testing.", new DateTime(2026, 1, 4, 16, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 88", null },
                    { 89, "This is the detailed content description for document request number 89 used for pagination testing.", new DateTime(2026, 1, 4, 17, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 89", null },
                    { 90, "This is the detailed content description for document request number 90 used for pagination testing.", new DateTime(2026, 1, 4, 18, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 90", null },
                    { 91, "This is the detailed content description for document request number 91 used for pagination testing.", new DateTime(2026, 1, 4, 19, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 91", null },
                    { 92, "This is the detailed content description for document request number 92 used for pagination testing.", new DateTime(2026, 1, 4, 20, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 92", null },
                    { 93, "This is the detailed content description for document request number 93 used for pagination testing.", new DateTime(2026, 1, 4, 21, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 93", null },
                    { 94, "This is the detailed content description for document request number 94 used for pagination testing.", new DateTime(2026, 1, 4, 22, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 94", null },
                    { 95, "This is the detailed content description for document request number 95 used for pagination testing.", new DateTime(2026, 1, 4, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 95", null },
                    { 96, "This is the detailed content description for document request number 96 used for pagination testing.", new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 96", null },
                    { 97, "This is the detailed content description for document request number 97 used for pagination testing.", new DateTime(2026, 1, 5, 1, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 97", null },
                    { 98, "This is the detailed content description for document request number 98 used for pagination testing.", new DateTime(2026, 1, 5, 2, 0, 0, 0, DateTimeKind.Utc), 1, null, "Pending", "Sample Document Request Title 98", null },
                    { 99, "This is the detailed content description for document request number 99 used for pagination testing.", new DateTime(2026, 1, 5, 3, 0, 0, 0, DateTimeKind.Utc), 1, null, "Checked", "Sample Document Request Title 99", null },
                    { 100, "This is the detailed content description for document request number 100 used for pagination testing.", new DateTime(2026, 1, 5, 4, 0, 0, 0, DateTimeKind.Utc), 1, null, "Authorized", "Sample Document Request Title 100", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$3JRjrpAdsyJl7tKoEPWbveHWKGsQk.xo3HfO5Kgo/ukqVIEPIyrAu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$3JRjrpAdsyJl7tKoEPWbveHWKGsQk.xo3HfO5Kgo/ukqVIEPIyrAu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$3JRjrpAdsyJl7tKoEPWbveHWKGsQk.xo3HfO5Kgo/ukqVIEPIyrAu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "DocumentRequests",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$RHq7l3k3FlwZ0hxehTLfV.7LBHN.Vh2eECz4bKZNQt6pzRXy7hBKS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$RHq7l3k3FlwZ0hxehTLfV.7LBHN.Vh2eECz4bKZNQt6pzRXy7hBKS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$RHq7l3k3FlwZ0hxehTLfV.7LBHN.Vh2eECz4bKZNQt6pzRXy7hBKS");
        }
    }
}
