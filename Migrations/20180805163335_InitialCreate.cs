using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EPLDataSet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    ManagerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.ManagerID);
                });

            migrationBuilder.CreateTable(
                name: "MatchDayTickets",
                columns: table => new
                {
                    ReserveMatchDayTicketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReserveDate = table.Column<DateTime>(nullable: false),
                    NoOfSeatsReserved = table.Column<int>(nullable: false),
                    ReserveStatus = table.Column<string>(nullable: true),
                    BuyStatus = table.Column<string>(nullable: true),
                    ExpireStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchDayTickets", x => x.ReserveMatchDayTicketID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserAccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    AccountType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserAccountID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustFirstName = table.Column<string>(nullable: false),
                    CustLastName = table.Column<string>(nullable: false),
                    ReserveMatchDayTicketID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customers_MatchDayTickets_ReserveMatchDayTicketID",
                        column: x => x.ReserveMatchDayTicketID,
                        principalTable: "MatchDayTickets",
                        principalColumn: "ReserveMatchDayTicketID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fixture",
                columns: table => new
                {
                    FixturesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeasonYear = table.Column<long>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    MatchResults = table.Column<string>(nullable: true),
                    ReserveMatchDayTicketID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixture", x => x.FixturesID);
                    table.ForeignKey(
                        name: "FK_Fixture_MatchDayTickets_ReserveMatchDayTicketID",
                        column: x => x.ReserveMatchDayTicketID,
                        principalTable: "MatchDayTickets",
                        principalColumn: "ReserveMatchDayTicketID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScoreDetails",
                columns: table => new
                {
                    ScoreDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FixturesID = table.Column<int>(nullable: true),
                    SeasonYear = table.Column<string>(nullable: true),
                    ScoreMinute = table.Column<int>(nullable: false),
                    ScoreKind = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreDetails", x => x.ScoreDetailID);
                    table.ForeignKey(
                        name: "FK_ScoreDetails_Fixture_FixturesID",
                        column: x => x.FixturesID,
                        principalTable: "Fixture",
                        principalColumn: "FixturesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stadiums",
                columns: table => new
                {
                    StadiumID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StadiumName = table.Column<string>(nullable: false),
                    StadiumLocation = table.Column<string>(nullable: false),
                    FixturesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadiums", x => x.StadiumID);
                    table.ForeignKey(
                        name: "FK_Stadiums_Fixture_FixturesID",
                        column: x => x.FixturesID,
                        principalTable: "Fixture",
                        principalColumn: "FixturesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamName = table.Column<string>(nullable: false),
                    TeamHomeTown = table.Column<string>(nullable: false),
                    ManagersManagerID = table.Column<int>(nullable: false),
                    TelephoneNo = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: false),
                    HomeJersey = table.Column<string>(nullable: true),
                    AwayJersey = table.Column<string>(nullable: true),
                    FixturesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                    table.ForeignKey(
                        name: "FK_Teams_Fixture_FixturesID",
                        column: x => x.FixturesID,
                        principalTable: "Fixture",
                        principalColumn: "FixturesID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Managers_ManagersManagerID",
                        column: x => x.ManagersManagerID,
                        principalTable: "Managers",
                        principalColumn: "ManagerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PlayerDOB = table.Column<int>(nullable: false),
                    PlayerPlaceOfBirth = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    JerseyNo = table.Column<int>(nullable: false),
                    PlayerGameStatus = table.Column<string>(nullable: false),
                    PlayerNationality = table.Column<string>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    TeamID = table.Column<int>(nullable: false),
                    ScoreDetailID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerID);
                    table.ForeignKey(
                        name: "FK_Players_ScoreDetails_ScoreDetailID",
                        column: x => x.ScoreDetailID,
                        principalTable: "ScoreDetails",
                        principalColumn: "ScoreDetailID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TopGoalScorers",
                columns: table => new
                {
                    TopGoalScorerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstNamePlayerID = table.Column<int>(nullable: true),
                    LastNamePlayerID = table.Column<int>(nullable: true),
                    PlayerRank = table.Column<int>(nullable: false),
                    TotalScore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopGoalScorers", x => x.TopGoalScorerID);
                    table.ForeignKey(
                        name: "FK_TopGoalScorers_Players_FirstNamePlayerID",
                        column: x => x.FirstNamePlayerID,
                        principalTable: "Players",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TopGoalScorers_Players_LastNamePlayerID",
                        column: x => x.LastNamePlayerID,
                        principalTable: "Players",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ReserveMatchDayTicketID",
                table: "Customers",
                column: "ReserveMatchDayTicketID");

            migrationBuilder.CreateIndex(
                name: "IX_Fixture_ReserveMatchDayTicketID",
                table: "Fixture",
                column: "ReserveMatchDayTicketID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_ScoreDetailID",
                table: "Players",
                column: "ScoreDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamID",
                table: "Players",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreDetails_FixturesID",
                table: "ScoreDetails",
                column: "FixturesID");

            migrationBuilder.CreateIndex(
                name: "IX_Stadiums_FixturesID",
                table: "Stadiums",
                column: "FixturesID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_FixturesID",
                table: "Teams",
                column: "FixturesID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ManagersManagerID",
                table: "Teams",
                column: "ManagersManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_TopGoalScorers_FirstNamePlayerID",
                table: "TopGoalScorers",
                column: "FirstNamePlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_TopGoalScorers_LastNamePlayerID",
                table: "TopGoalScorers",
                column: "LastNamePlayerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Stadiums");

            migrationBuilder.DropTable(
                name: "TopGoalScorers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "ScoreDetails");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Fixture");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "MatchDayTickets");
        }
    }
}
