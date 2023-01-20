using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FieryRestaurant.Supplier.Model.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    SupplierId = table.Column<string>(name: "Supplier_Id", type: "nvarchar(450)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "business",
                columns: table => new
                {
                    SupplierId = table.Column<string>(name: "Supplier_Id", type: "nvarchar(450)", nullable: false),
                    BusinessName = table.Column<string>(name: "Business_Name", type: "nvarchar(max)", nullable: false),
                    LicenseNo = table.Column<long>(name: "License_No", type: "bigint", nullable: false),
                    LicenseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<string>(name: "Supplier_Id", type: "nvarchar(450)", nullable: false),
                    SupplierName = table.Column<string>(name: "Supplier_Name", type: "nvarchar(max)", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddressSupplierId = table.Column<string>(name: "AddressSupplier_Id", type: "nvarchar(450)", nullable: true),
                    BusinessSupplierId = table.Column<string>(name: "BusinessSupplier_Id", type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_suppliers_addresses_AddressSupplier_Id",
                        column: x => x.AddressSupplierId,
                        principalTable: "addresses",
                        principalColumn: "Supplier_Id");
                    table.ForeignKey(
                        name: "FK_suppliers_business_BusinessSupplier_Id",
                        column: x => x.BusinessSupplierId,
                        principalTable: "business",
                        principalColumn: "Supplier_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_suppliers_AddressSupplier_Id",
                table: "suppliers",
                column: "AddressSupplier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_suppliers_BusinessSupplier_Id",
                table: "suppliers",
                column: "BusinessSupplier_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "business");
        }
    }
}
