using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rpgapi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvestmentStrategies",
                columns: table => new
                {
                    InvestmentStrategyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrategyName = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    AccountID = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: false),
                    ModelAPLID = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: false),
                    InvestmentAmount = table.Column<decimal>(type: "decimal(17,5)", nullable: false),
                    InvestmentTypeID = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    DeletedFlag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestmentStrategies", x => x.InvestmentStrategyID);
                });

            migrationBuilder.CreateTable(
                name: "InvestmentTypes",
                columns: table => new
                {
                    InvestmentTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvestmentTypeName = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    DeletedFlag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestmentTypes", x => x.InvestmentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "InvestorInfos",
                columns: table => new
                {
                    InvestorInfoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    InvestmentName = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    Active = table.Column<byte>(type: "Tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    DeletedFlag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestorInfos", x => x.InvestorInfoID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    Active = table.Column<byte>(type: "Tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true),
                    State = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    Phone = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    AdvisorID = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: true),
                    AgentID = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: true),
                    ClientID = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Company = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    SortName = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false, computedColumnSql: "[LastName] + ' ' + [FirstName]"),
                    Active = table.Column<byte>(type: "Tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    DeletedFlag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvestmentStrategies");

            migrationBuilder.DropTable(
                name: "InvestmentTypes");

            migrationBuilder.DropTable(
                name: "InvestorInfos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
