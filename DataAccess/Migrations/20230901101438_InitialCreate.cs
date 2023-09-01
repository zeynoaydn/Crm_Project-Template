using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "City");

            migrationBuilder.EnsureSchema(
                name: "Report");

            migrationBuilder.EnsureSchema(
                name: "Communication");

            migrationBuilder.EnsureSchema(
                name: "Country");

            migrationBuilder.EnsureSchema(
                name: "Customer");

            migrationBuilder.EnsureSchema(
                name: "Department");

            migrationBuilder.EnsureSchema(
                name: "Employee");

            migrationBuilder.EnsureSchema(
                name: "Offer");

            migrationBuilder.EnsureSchema(
                name: "Permission");

            migrationBuilder.EnsureSchema(
                name: "Product");

            migrationBuilder.EnsureSchema(
                name: "Prospect");

            migrationBuilder.EnsureSchema(
                name: "Role");

            migrationBuilder.EnsureSchema(
                name: "Sales");

            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.CreateTable(
                name: "CommunicationTypes",
                schema: "Communication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offerings",
                schema: "Offer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    ValidDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offerings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                schema: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionName = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                schema: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    NumberOfProduct = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationReport",
                schema: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunicationLogId = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerSurname = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerPhoneNumber = table.Column<int>(nullable: false),
                    CustomerEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CustomerAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CustomerCompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerCompanyAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CustomerCompanyPhoneNumber = table.Column<int>(nullable: false),
                    ProspectsName = table.Column<string>(maxLength: 50, nullable: false),
                    ProspectSurname = table.Column<string>(maxLength: 50, nullable: false),
                    ProspectEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ProspectPhoneNumber = table.Column<int>(nullable: false),
                    ProspectCompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    ProspectAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialReport",
                schema: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 50, nullable: false),
                    NumberOfProduct = table.Column<int>(nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    ProductDescription = table.Column<string>(type: "text", nullable: false),
                    SalesTotalPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    SalesQuantity = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfferReport",
                schema: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesOpportunitiesName = table.Column<string>(maxLength: 50, nullable: false),
                    SalesOpportunitiesAmount = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    SalesOpportunitiesStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    SalesOpportunitiesEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    SalesOpportunitiesStatus = table.Column<bool>(nullable: false),
                    OfferName = table.Column<string>(maxLength: 50, nullable: false),
                    OfferAmount = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    OfferValidDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OfferDescription = table.Column<string>(maxLength: 50, nullable: false),
                    SalesStatusStatus = table.Column<string>(maxLength: 50, nullable: false),
                    SalesStatusNotes = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockReport",
                schema: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 50, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    ProductDescription = table.Column<string>(type: "text", nullable: false),
                    NumberOfProduct = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    RoleName = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(maxLength: 50, nullable: false),
                    PasswordSalt = table.Column<byte[]>(maxLength: 50, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(nullable: false),
                    CityName = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries",
                        column: x => x.CountryId,
                        principalSchema: "Country",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products_ProductCategories",
                schema: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategory",
                        column: x => x.ProductCategoryId,
                        principalSchema: "Product",
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_Products",
                        column: x => x.ProductId,
                        principalSchema: "Product",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles_Permissions",
                schema: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Permission_Permissions",
                        column: x => x.PermissionId,
                        principalSchema: "Permission",
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Role_Permission_Roles",
                        column: x => x.RoleId,
                        principalSchema: "Role",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Address = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    IdentificationNumber = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Users",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users_Departments",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Department_Departments",
                        column: x => x.DepartmentId,
                        principalSchema: "Department",
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Department_Users",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users_Roles",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_Roles",
                        column: x => x.RoleId,
                        principalSchema: "Role",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Role_Users",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Address = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    CompanyAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CompanyPhone = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Cities",
                        column: x => x.CityId,
                        principalSchema: "City",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Countries",
                        column: x => x.CountryId,
                        principalSchema: "Country",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Users",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prospects",
                schema: "Prospect",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prospects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prospects_Cities",
                        column: x => x.CityId,
                        principalSchema: "City",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prospects_Countries",
                        column: x => x.CountryId,
                        principalSchema: "Country",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prospects_Users",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerReport",
                schema: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitiesId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    SalesId = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerSurname = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerPhoneNumber = table.Column<int>(nullable: false),
                    CustomerEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CustomerAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CustomerCompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerCompanyAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CustomerCompanyPhoneNumber = table.Column<int>(nullable: false),
                    ProspectName = table.Column<string>(maxLength: 50, nullable: false),
                    ProspectSurname = table.Column<string>(maxLength: 50, nullable: false),
                    ProspectEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ProspectPhoneNumber = table.Column<int>(nullable: false),
                    ProspectCompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    ProspectAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    OfferName = table.Column<string>(maxLength: 50, nullable: false),
                    OfferAmount = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    OfferValidDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OfferDescription = table.Column<string>(maxLength: 50, nullable: false),
                    SalesOpportunitiesName = table.Column<string>(maxLength: 50, nullable: false),
                    SalesOpportunitiesAmount = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    SalesOpportunitiesStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    SalesOpportunitiesEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    SalesOpportunitiesStatus = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerReport_Cities",
                        column: x => x.CitiesId,
                        principalSchema: "City",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerReport_Countries",
                        column: x => x.CountryId,
                        principalSchema: "Country",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesPerformanceReport",
                schema: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitiesId = table.Column<int>(nullable: false),
                    CountriesId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 50, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    ProductDescription = table.Column<string>(type: "text", nullable: false),
                    SalesTotalPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    SalesDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SalesQuantity = table.Column<int>(nullable: false),
                    EmployeeName = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeeSurname = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeeAge = table.Column<int>(nullable: false),
                    EmployeeAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    EmployeePhoneNumber = table.Column<int>(nullable: false),
                    EmployeeIdentificationNumber = table.Column<int>(nullable: false),
                    EmployeeBirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CustomerName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerSurname = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerPhoneNumber = table.Column<int>(nullable: false),
                    CustomerEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CustomerAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CustomerCompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerCompanyAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CustomerCompanyPhone = table.Column<int>(nullable: false),
                    ProspectName = table.Column<string>(maxLength: 50, nullable: false),
                    ProspectSurname = table.Column<string>(maxLength: 50, nullable: false),
                    ProspectEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ProspectPhoneNumber = table.Column<int>(nullable: false),
                    ProspectCompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    ProspectAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPerformanceReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesPerformanceReport_Cities",
                        column: x => x.CitiesId,
                        principalSchema: "City",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesPerformanceReport_Countries",
                        column: x => x.CountriesId,
                        principalSchema: "Country",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCommunicationLog",
                schema: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    CommunicationTypeId = table.Column<int>(nullable: false),
                    CommunicationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CommunicationDetails = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCommunicationLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerCommunicationLog_CommunicationType",
                        column: x => x.CommunicationTypeId,
                        principalSchema: "Communication",
                        principalTable: "CommunicationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerCommunicationLog_Customers",
                        column: x => x.CustomerId,
                        principalSchema: "Customer",
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers_Employees",
                schema: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Employee_Customers",
                        column: x => x.CustomerId,
                        principalSchema: "Customer",
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Employee_Employees",
                        column: x => x.EmployeeId,
                        principalSchema: "Employee",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                schema: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Customers",
                        column: x => x.CustomerId,
                        principalSchema: "Customer",
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prospects_Customers",
                schema: "Prospect",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProspectsId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prospects_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prospect_Customer_Customers",
                        column: x => x.CustomerId,
                        principalSchema: "Customer",
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prospect_Customer_Prospects",
                        column: x => x.ProspectsId,
                        principalSchema: "Prospect",
                        principalTable: "Prospects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProspectsCommunicationLog",
                schema: "Prospect",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProspectId = table.Column<int>(nullable: false),
                    CommunicationTypeId = table.Column<int>(nullable: false),
                    CommunicationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CommunicationDetails = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProspectsCommunicationLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunicationLog_CommunicationType",
                        column: x => x.CommunicationTypeId,
                        principalSchema: "Communication",
                        principalTable: "CommunicationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProspectsCommunicationLog_Prospects",
                        column: x => x.ProspectId,
                        principalSchema: "Prospect",
                        principalTable: "Prospects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesOpportunities",
                schema: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProspectId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOpportunities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOpportunities_Prospects",
                        column: x => x.ProspectId,
                        principalSchema: "Prospect",
                        principalTable: "Prospects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesDetails",
                schema: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    SalesId = table.Column<int>(nullable: false),
                    SalesDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Products",
                        column: x => x.ProductId,
                        principalSchema: "Product",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Sales",
                        column: x => x.SalesId,
                        principalSchema: "Sales",
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesOpportunities_Offerings",
                schema: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesOpportunitiesId = table.Column<int>(nullable: false),
                    OfferId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOpportunities_Offerings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOpportunities_Offer_Offerings",
                        column: x => x.OfferId,
                        principalSchema: "Offer",
                        principalTable: "Offerings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesOpportunities_Offer_SalesOpportunities",
                        column: x => x.SalesOpportunitiesId,
                        principalSchema: "Sales",
                        principalTable: "SalesOpportunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesStatus",
                schema: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesOpportunitiesId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesStatus_SalesOpportunities",
                        column: x => x.SalesOpportunitiesId,
                        principalSchema: "Sales",
                        principalTable: "SalesOpportunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                schema: "City",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCommunicationLog_CommunicationTypeId",
                schema: "Customer",
                table: "CustomerCommunicationLog",
                column: "CommunicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCommunicationLog_CustomerId",
                schema: "Customer",
                table: "CustomerCommunicationLog",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CityId",
                schema: "Customer",
                table: "Customers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountryId",
                schema: "Customer",
                table: "Customers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                schema: "Customer",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Employees_CustomerId",
                schema: "Customer",
                table: "Customers_Employees",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Employees_EmployeeId",
                schema: "Customer",
                table: "Customers_Employees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                schema: "Employee",
                table: "Employees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategories_ProductCategoryId",
                schema: "Product",
                table: "Products_ProductCategories",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategories_ProductId",
                schema: "Product",
                table: "Products_ProductCategories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Prospects_CityId",
                schema: "Prospect",
                table: "Prospects",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Prospects_CountryId",
                schema: "Prospect",
                table: "Prospects",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Prospects_UserId",
                schema: "Prospect",
                table: "Prospects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Prospects_Customers_CustomerId",
                schema: "Prospect",
                table: "Prospects_Customers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Prospects_Customers_ProspectsId",
                schema: "Prospect",
                table: "Prospects_Customers",
                column: "ProspectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProspectsCommunicationLog_CommunicationTypeId",
                schema: "Prospect",
                table: "ProspectsCommunicationLog",
                column: "CommunicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProspectsCommunicationLog_ProspectId",
                schema: "Prospect",
                table: "ProspectsCommunicationLog",
                column: "ProspectId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerReport_CitiesId",
                schema: "Report",
                table: "CustomerReport",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerReport_CountryId",
                schema: "Report",
                table: "CustomerReport",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesPerformanceReport_CitiesId",
                schema: "Report",
                table: "SalesPerformanceReport",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesPerformanceReport_CountriesId",
                schema: "Report",
                table: "SalesPerformanceReport",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Permissions_PermissionId",
                schema: "Role",
                table: "Roles_Permissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Permissions_RoleId",
                schema: "Role",
                table: "Roles_Permissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                schema: "Sales",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_ProductId",
                schema: "Sales",
                table: "SalesDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_SalesId",
                schema: "Sales",
                table: "SalesDetails",
                column: "SalesId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOpportunities_ProspectId",
                schema: "Sales",
                table: "SalesOpportunities",
                column: "ProspectId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOpportunities_Offerings_OfferId",
                schema: "Sales",
                table: "SalesOpportunities_Offerings",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOpportunities_Offerings_SalesOpportunitiesId",
                schema: "Sales",
                table: "SalesOpportunities_Offerings",
                column: "SalesOpportunitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesStatus_SalesOpportunitiesId",
                schema: "Sales",
                table: "SalesStatus",
                column: "SalesOpportunitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Departments_DepartmentId",
                schema: "User",
                table: "Users_Departments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Departments_UserId",
                schema: "User",
                table: "Users_Departments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Roles_RoleId",
                schema: "User",
                table: "Users_Roles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Roles_UserId",
                schema: "User",
                table: "Users_Roles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCommunicationLog",
                schema: "Customer");

            migrationBuilder.DropTable(
                name: "Customers_Employees",
                schema: "Customer");

            migrationBuilder.DropTable(
                name: "Products_ProductCategories",
                schema: "Product");

            migrationBuilder.DropTable(
                name: "Prospects_Customers",
                schema: "Prospect");

            migrationBuilder.DropTable(
                name: "ProspectsCommunicationLog",
                schema: "Prospect");

            migrationBuilder.DropTable(
                name: "CommunicationReport",
                schema: "Report");

            migrationBuilder.DropTable(
                name: "CustomerReport",
                schema: "Report");

            migrationBuilder.DropTable(
                name: "FinancialReport",
                schema: "Report");

            migrationBuilder.DropTable(
                name: "OfferReport",
                schema: "Report");

            migrationBuilder.DropTable(
                name: "SalesPerformanceReport",
                schema: "Report");

            migrationBuilder.DropTable(
                name: "StockReport",
                schema: "Report");

            migrationBuilder.DropTable(
                name: "Roles_Permissions",
                schema: "Role");

            migrationBuilder.DropTable(
                name: "SalesDetails",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesOpportunities_Offerings",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesStatus",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Users_Departments",
                schema: "User");

            migrationBuilder.DropTable(
                name: "Users_Roles",
                schema: "User");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "Employee");

            migrationBuilder.DropTable(
                name: "ProductCategories",
                schema: "Product");

            migrationBuilder.DropTable(
                name: "CommunicationTypes",
                schema: "Communication");

            migrationBuilder.DropTable(
                name: "Permissions",
                schema: "Permission");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Product");

            migrationBuilder.DropTable(
                name: "Sales",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Offerings",
                schema: "Offer");

            migrationBuilder.DropTable(
                name: "SalesOpportunities",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "Department");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "Role");

            migrationBuilder.DropTable(
                name: "Customers",
                schema: "Customer");

            migrationBuilder.DropTable(
                name: "Prospects",
                schema: "Prospect");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "City");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "User");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "Country");
        }
    }
}
