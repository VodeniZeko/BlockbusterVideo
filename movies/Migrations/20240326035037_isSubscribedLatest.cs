using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movies.Migrations
{
    /// <inheritdoc />
    public partial class isSubscribedLatest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isSubscribedToNewsletter",
                table: "Customers",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isSubscribedToNewsletter",
                table: "Customers");
        }
    }
}
