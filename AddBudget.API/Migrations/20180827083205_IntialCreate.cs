using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddBudget.API.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    BudgetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnglishName = table.Column<string>(nullable: true),
                    ArabicName = table.Column<string>(nullable: true),
                    EnglishDescrption = table.Column<string>(nullable: false),
                    ArabicDescrption = table.Column<string>(nullable: true),
                    NumberOfBranchesAlreadyPerformed = table.Column<int>(nullable: false),
                    NumberOfBranchesUnderConstruction = table.Column<int>(nullable: false),
                    NumberOfForecastedBranches = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    EstimatedDeadline = table.Column<DateTime>(nullable: true),
                    ActualDeadline = table.Column<DateTime>(nullable: true),
                    ActiveFlag = table.Column<bool>(nullable: true),
                    DeleteFlag = table.Column<bool>(nullable: true),
                    EntryUser = table.Column<string>(nullable: true),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryTime = table.Column<DateTime>(nullable: false),
                    LastModificationUser = table.Column<string>(nullable: true),
                    LastModificationDate = table.Column<DateTime>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    DeleteUser = table.Column<string>(nullable: true),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    DeleteTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.BudgetId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budgets");
        }
    }
}
