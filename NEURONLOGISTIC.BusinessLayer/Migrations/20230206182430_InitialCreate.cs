using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NEURONLOGISTIC.BusinessLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    StartWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveWork = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MotherFullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FatherFullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Airlines_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Airlines_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Airlines_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Airlines_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Airports_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Airports_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Airports_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Airports_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CargoTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ShipmentTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargoTypes_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CargoTypes_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CargoTypes_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CargoTypes_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CargoTypes_ShipmentTypes_ShipmentTypeId",
                        column: x => x.ShipmentTypeId,
                        principalTable: "ShipmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyTypes_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyTypes_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyTypes_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyTypes_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Containers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Teu = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Containers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Containers_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Containers_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Containers_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Containers_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ThousandsSeparator = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    DecimalSeparator = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    SymbolOnLeft = table.Column<bool>(type: "bit", nullable: false),
                    SpaceBetweenAmountAndSymbol = table.Column<bool>(type: "bit", nullable: false),
                    DecimalDigits = table.Column<short>(type: "smallint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Currencies_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Currencies_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Currencies_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Currencies_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customss_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customss_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customss_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customss_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceTypes_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceTypes_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceTypes_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceTypes_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PackageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageTypes_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackageTypes_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackageTypes_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackageTypes_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Terms_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Terms_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Terms_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Terms_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ports_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ports_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ports_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ports_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ports_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    YearConstruction = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Imo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ships_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ships_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ships_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ships_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ships_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CompanyTypeId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    WebLink = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalespersonImportId = table.Column<int>(type: "int", nullable: true),
                    SalespersonExportId = table.Column<int>(type: "int", nullable: true),
                    SalespersonAirId = table.Column<int>(type: "int", nullable: true),
                    SalespersonSupportId = table.Column<int>(type: "int", nullable: true),
                    SalesCurrentCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PurchaseCurrentCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreditDay = table.Column<int>(type: "int", nullable: true),
                    AirCreditDay = table.Column<int>(type: "int", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TaxOffice = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: true),
                    InvoiceTypeId = table.Column<int>(type: "int", nullable: true),
                    MersisNo = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    AccountNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_CompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "CompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Employees_SalespersonAirId",
                        column: x => x.SalespersonAirId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Employees_SalespersonExportId",
                        column: x => x.SalespersonExportId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Employees_SalespersonImportId",
                        column: x => x.SalespersonImportId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Employees_SalespersonSupportId",
                        column: x => x.SalespersonSupportId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_InvoiceTypes_InvoiceTypeId",
                        column: x => x.InvoiceTypeId,
                        principalTable: "InvoiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Voyages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShipId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voyages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voyages_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voyages_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voyages_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voyages_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voyages_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    PortOffice = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DeletedByEmployeeId = table.Column<int>(type: "int", nullable: true),
                    EntitiyStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lines_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lines_Employees_CreatedByEmployeeId",
                        column: x => x.CreatedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lines_Employees_DeletedByEmployeeId",
                        column: x => x.DeletedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lines_Employees_LastModifiedByEmployeeId",
                        column: x => x.LastModifiedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lines_EntityStatuses_EntitiyStatusId",
                        column: x => x.EntitiyStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Airlines_CreatedByEmployeeId",
                table: "Airlines",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Airlines_DeletedByEmployeeId",
                table: "Airlines",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Airlines_EntitiyStatusId",
                table: "Airlines",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Airlines_LastModifiedByEmployeeId",
                table: "Airlines",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_CreatedByEmployeeId",
                table: "Airports",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_DeletedByEmployeeId",
                table: "Airports",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_EntitiyStatusId",
                table: "Airports",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_LastModifiedByEmployeeId",
                table: "Airports",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoTypes_CreatedByEmployeeId",
                table: "CargoTypes",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoTypes_DeletedByEmployeeId",
                table: "CargoTypes",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoTypes_EntitiyStatusId",
                table: "CargoTypes",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoTypes_LastModifiedByEmployeeId",
                table: "CargoTypes",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoTypes_ShipmentTypeId",
                table: "CargoTypes",
                column: "ShipmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CreatedByEmployeeId",
                table: "Cities",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_DeletedByEmployeeId",
                table: "Cities",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_EntitiyStatusId",
                table: "Cities",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_LastModifiedByEmployeeId",
                table: "Cities",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CityId",
                table: "Companies",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CountryId",
                table: "Companies",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CreatedByEmployeeId",
                table: "Companies",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CurrencyId",
                table: "Companies",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_DeletedByEmployeeId",
                table: "Companies",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_EntitiyStatusId",
                table: "Companies",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_InvoiceTypeId",
                table: "Companies",
                column: "InvoiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_LastModifiedByEmployeeId",
                table: "Companies",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_PaymentTypeId",
                table: "Companies",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SalespersonAirId",
                table: "Companies",
                column: "SalespersonAirId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SalespersonExportId",
                table: "Companies",
                column: "SalespersonExportId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SalespersonImportId",
                table: "Companies",
                column: "SalespersonImportId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SalespersonSupportId",
                table: "Companies",
                column: "SalespersonSupportId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTypes_CreatedByEmployeeId",
                table: "CompanyTypes",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTypes_DeletedByEmployeeId",
                table: "CompanyTypes",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTypes_EntitiyStatusId",
                table: "CompanyTypes",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTypes_LastModifiedByEmployeeId",
                table: "CompanyTypes",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_CreatedByEmployeeId",
                table: "Containers",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_DeletedByEmployeeId",
                table: "Containers",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_EntitiyStatusId",
                table: "Containers",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_LastModifiedByEmployeeId",
                table: "Containers",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CreatedByEmployeeId",
                table: "Countries",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_DeletedByEmployeeId",
                table: "Countries",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_EntitiyStatusId",
                table: "Countries",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_LastModifiedByEmployeeId",
                table: "Countries",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_CreatedByEmployeeId",
                table: "Currencies",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_DeletedByEmployeeId",
                table: "Currencies",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_EntitiyStatusId",
                table: "Currencies",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_LastModifiedByEmployeeId",
                table: "Currencies",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customss_CreatedByEmployeeId",
                table: "Customss",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customss_DeletedByEmployeeId",
                table: "Customss",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customss_EntitiyStatusId",
                table: "Customss",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Customss_LastModifiedByEmployeeId",
                table: "Customss",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BranchId",
                table: "Employees",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleId",
                table: "Employees",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceTypes_CreatedByEmployeeId",
                table: "InvoiceTypes",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceTypes_DeletedByEmployeeId",
                table: "InvoiceTypes",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceTypes_EntitiyStatusId",
                table: "InvoiceTypes",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceTypes_LastModifiedByEmployeeId",
                table: "InvoiceTypes",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lines_CompanyId",
                table: "Lines",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Lines_CreatedByEmployeeId",
                table: "Lines",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lines_DeletedByEmployeeId",
                table: "Lines",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lines_EntitiyStatusId",
                table: "Lines",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Lines_LastModifiedByEmployeeId",
                table: "Lines",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageTypes_CreatedByEmployeeId",
                table: "PackageTypes",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageTypes_DeletedByEmployeeId",
                table: "PackageTypes",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageTypes_EntitiyStatusId",
                table: "PackageTypes",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageTypes_LastModifiedByEmployeeId",
                table: "PackageTypes",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_CreatedByEmployeeId",
                table: "PaymentTypes",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_DeletedByEmployeeId",
                table: "PaymentTypes",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_EntitiyStatusId",
                table: "PaymentTypes",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_LastModifiedByEmployeeId",
                table: "PaymentTypes",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ports_CountryId",
                table: "Ports",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ports_CreatedByEmployeeId",
                table: "Ports",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ports_DeletedByEmployeeId",
                table: "Ports",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ports_EntitiyStatusId",
                table: "Ports",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Ports_LastModifiedByEmployeeId",
                table: "Ports",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_CountryId",
                table: "Ships",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_CreatedByEmployeeId",
                table: "Ships",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_DeletedByEmployeeId",
                table: "Ships",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_EntitiyStatusId",
                table: "Ships",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_LastModifiedByEmployeeId",
                table: "Ships",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_CreatedByEmployeeId",
                table: "Terms",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_DeletedByEmployeeId",
                table: "Terms",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_EntitiyStatusId",
                table: "Terms",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_LastModifiedByEmployeeId",
                table: "Terms",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyages_CreatedByEmployeeId",
                table: "Voyages",
                column: "CreatedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyages_DeletedByEmployeeId",
                table: "Voyages",
                column: "DeletedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyages_EntitiyStatusId",
                table: "Voyages",
                column: "EntitiyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyages_LastModifiedByEmployeeId",
                table: "Voyages",
                column: "LastModifiedByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyages_ShipId",
                table: "Voyages",
                column: "ShipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airlines");

            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "CargoTypes");

            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.DropTable(
                name: "Customss");

            migrationBuilder.DropTable(
                name: "CustomsTypes");

            migrationBuilder.DropTable(
                name: "Lines");

            migrationBuilder.DropTable(
                name: "PackageTypes");

            migrationBuilder.DropTable(
                name: "Ports");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropTable(
                name: "Voyages");

            migrationBuilder.DropTable(
                name: "ShipmentTypes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Ships");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "InvoiceTypes");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "EntityStatuses");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
