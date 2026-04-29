using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace core.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ssn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TaxesNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClientType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActivityType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActivityAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ClientAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsVip = table.Column<bool>(type: "bit", nullable: false),
                    HasAddedValue = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ROLE",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLE", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "CLIENT_PHONE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT_PHONE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CLIENT_PHONE_CLIENT_ClientId",
                        column: x => x.ClientId,
                        principalTable: "CLIENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEE_PHONE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE_PHONE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EMPLOYEE_PHONE_EMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FINANCIALS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FeeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FINANCIALS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FINANCIALS_CLIENT_ClientId",
                        column: x => x.ClientId,
                        principalTable: "CLIENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FINANCIALS_EMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TASKS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DoneDate = table.Column<DateOnly>(type: "date", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsDone = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASKS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TASKS_CLIENT_ClientId",
                        column: x => x.ClientId,
                        principalTable: "CLIENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_TASKS_EMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEE_ROLE",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE_ROLE", x => new { x.EmployeeId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_EMPLOYEE_ROLE_EMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EMPLOYEE_ROLE_ROLE_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ROLE",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLIENT_PHONE_ClientId",
                table: "CLIENT_PHONE",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_PHONE_EmployeeId",
                table: "EMPLOYEE_PHONE",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_ROLE_RoleId",
                table: "EMPLOYEE_ROLE",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_FINANCIALS_ClientId",
                table: "FINANCIALS",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_FINANCIALS_EmployeeId",
                table: "FINANCIALS",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TASKS_ClientId",
                table: "TASKS",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TASKS_EmployeeId",
                table: "TASKS",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENT_PHONE");

            migrationBuilder.DropTable(
                name: "EMPLOYEE_PHONE");

            migrationBuilder.DropTable(
                name: "EMPLOYEE_ROLE");

            migrationBuilder.DropTable(
                name: "FINANCIALS");

            migrationBuilder.DropTable(
                name: "TASKS");

            migrationBuilder.DropTable(
                name: "ROLE");

            migrationBuilder.DropTable(
                name: "CLIENT");

            migrationBuilder.DropTable(
                name: "EMPLOYEE");
        }
    }
}
