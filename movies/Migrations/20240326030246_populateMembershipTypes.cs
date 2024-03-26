using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movies.Migrations
{
    /// <inheritdoc />
    public partial class populateMembershipTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new[] { "Id", "SignUpFee", "DurationinMonths", "DiscountRate" },
                values: new object[] { 1, 30, 0, 0 });

            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new[] { "Id", "SignUpFee", "DurationinMonths", "DiscountRate" },
                values: new object[] { 2, 30, 1, 10 });

            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new[] { "Id", "SignUpFee", "DurationinMonths", "DiscountRate" },
                values: new object[] { 3, 90, 3, 15 });

            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new[] { "Id", "SignUpFee", "DurationinMonths", "DiscountRate" },
                values: new object[] { 4, 300, 12, 20 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
