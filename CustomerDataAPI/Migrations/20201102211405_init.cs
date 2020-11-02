using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerDataAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    Dob = table.Column<DateTime>(nullable: false),
                    BillingAddress__StreetAddress = table.Column<string>(nullable: false),
                    BillingAddress__City = table.Column<string>(nullable: false),
                    BillingAddress__State = table.Column<string>(nullable: false),
                    BillingAddress__PostalCode = table.Column<string>(nullable: false),
                    ShippingAddress__StreetAddress = table.Column<string>(nullable: false),
                    ShippingAddress__City = table.Column<string>(nullable: false),
                    ShippingAddress__State = table.Column<string>(nullable: false),
                    ShippingAddress__PostalCode = table.Column<string>(nullable: false),
                    PhoneNumber__Home = table.Column<string>(nullable: true),
                    PhoneNumber__Mobile = table.Column<string>(nullable: false),
                    PhoneNumber__Fax = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
