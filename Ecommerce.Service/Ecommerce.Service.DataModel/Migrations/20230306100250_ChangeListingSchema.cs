using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Service.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class ChangeListingSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Listings",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Listings",
                newName: "ListingId");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Listings",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryMethod",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Listings",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Listings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryMethod",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Listings");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Listings",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "ListingId",
                table: "Listings",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
