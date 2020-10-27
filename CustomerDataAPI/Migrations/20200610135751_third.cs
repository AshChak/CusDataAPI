using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerDataAPI.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: false),
                    BillingAddress__StreetAddress = table.Column<string>(nullable: true),
                    BillingAddress__City = table.Column<string>(nullable: true),
                    BillingAddress__State = table.Column<string>(nullable: true),
                    BillingAddress__PostalCode = table.Column<string>(nullable: true),
                    ShippingAddress__StreetAddress = table.Column<string>(nullable: true),
                    ShippingAddress__City = table.Column<string>(nullable: true),
                    ShippingAddress__State = table.Column<string>(nullable: true),
                    ShippingAddress__PostalCode = table.Column<string>(nullable: true),
                    PhoneNumber__Home = table.Column<string>(nullable: true),
                    PhoneNumber__Mobile = table.Column<string>(nullable: true),
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
