﻿// <auto-generated />
using System;
using EPLDataSet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EPLDataSet.Migrations
{
    [DbContext(typeof(EPLContext))]
    [Migration("20180805163335_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EPLDataSet.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustFirstName")
                        .IsRequired();

                    b.Property<string>("CustLastName")
                        .IsRequired();

                    b.Property<int?>("ReserveMatchDayTicketID");

                    b.HasKey("CustomerID");

                    b.HasIndex("ReserveMatchDayTicketID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EPLDataSet.Models.Fixtures", b =>
                {
                    b.Property<int>("FixturesID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("MatchResults");

                    b.Property<int?>("ReserveMatchDayTicketID");

                    b.Property<long>("SeasonYear");

                    b.HasKey("FixturesID");

                    b.HasIndex("ReserveMatchDayTicketID");

                    b.ToTable("Fixture");
                });

            modelBuilder.Entity("EPLDataSet.Models.Manager", b =>
                {
                    b.Property<int>("ManagerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("ManagerID");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("EPLDataSet.Models.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("JerseyNo");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("PlayerDOB");

                    b.Property<string>("PlayerGameStatus")
                        .IsRequired();

                    b.Property<string>("PlayerNationality")
                        .IsRequired();

                    b.Property<string>("PlayerPlaceOfBirth");

                    b.Property<string>("Position");

                    b.Property<int?>("ScoreDetailID");

                    b.Property<int>("TeamID");

                    b.HasKey("PlayerID");

                    b.HasIndex("ScoreDetailID");

                    b.HasIndex("TeamID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("EPLDataSet.Models.ReserveMatchDayTicket", b =>
                {
                    b.Property<int>("ReserveMatchDayTicketID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuyStatus");

                    b.Property<string>("ExpireStatus");

                    b.Property<int>("NoOfSeatsReserved");

                    b.Property<DateTime>("ReserveDate");

                    b.Property<string>("ReserveStatus");

                    b.HasKey("ReserveMatchDayTicketID");

                    b.ToTable("MatchDayTickets");
                });

            modelBuilder.Entity("EPLDataSet.Models.ScoreDetail", b =>
                {
                    b.Property<int>("ScoreDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FixturesID");

                    b.Property<string>("ScoreKind");

                    b.Property<int>("ScoreMinute");

                    b.Property<string>("SeasonYear");

                    b.HasKey("ScoreDetailID");

                    b.HasIndex("FixturesID");

                    b.ToTable("ScoreDetails");
                });

            modelBuilder.Entity("EPLDataSet.Models.Stadium", b =>
                {
                    b.Property<int>("StadiumID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FixturesID");

                    b.Property<string>("StadiumLocation")
                        .IsRequired();

                    b.Property<string>("StadiumName")
                        .IsRequired();

                    b.HasKey("StadiumID");

                    b.HasIndex("FixturesID");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("EPLDataSet.Models.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AwayJersey");

                    b.Property<int?>("FixturesID");

                    b.Property<string>("HomeJersey");

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<int>("ManagersManagerID");

                    b.Property<string>("TeamHomeTown")
                        .IsRequired();

                    b.Property<string>("TeamName")
                        .IsRequired();

                    b.Property<string>("TelephoneNo");

                    b.HasKey("TeamID");

                    b.HasIndex("FixturesID");

                    b.HasIndex("ManagersManagerID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EPLDataSet.Models.TopGoalScorer", b =>
                {
                    b.Property<int>("TopGoalScorerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FirstNamePlayerID");

                    b.Property<int?>("LastNamePlayerID");

                    b.Property<int>("PlayerRank");

                    b.Property<int>("TotalScore");

                    b.HasKey("TopGoalScorerID");

                    b.HasIndex("FirstNamePlayerID");

                    b.HasIndex("LastNamePlayerID");

                    b.ToTable("TopGoalScorers");
                });

            modelBuilder.Entity("EPLDataSet.Models.UserAccount", b =>
                {
                    b.Property<int>("UserAccountID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountType")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UserAccountID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EPLDataSet.Models.Customer", b =>
                {
                    b.HasOne("EPLDataSet.Models.ReserveMatchDayTicket")
                        .WithMany("Customer")
                        .HasForeignKey("ReserveMatchDayTicketID");
                });

            modelBuilder.Entity("EPLDataSet.Models.Fixtures", b =>
                {
                    b.HasOne("EPLDataSet.Models.ReserveMatchDayTicket")
                        .WithMany("Fixture")
                        .HasForeignKey("ReserveMatchDayTicketID");
                });

            modelBuilder.Entity("EPLDataSet.Models.Player", b =>
                {
                    b.HasOne("EPLDataSet.Models.ScoreDetail")
                        .WithMany("PlayerID")
                        .HasForeignKey("ScoreDetailID");

                    b.HasOne("EPLDataSet.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EPLDataSet.Models.ScoreDetail", b =>
                {
                    b.HasOne("EPLDataSet.Models.Fixtures", "Fixture")
                        .WithMany()
                        .HasForeignKey("FixturesID");
                });

            modelBuilder.Entity("EPLDataSet.Models.Stadium", b =>
                {
                    b.HasOne("EPLDataSet.Models.Fixtures")
                        .WithMany("StadiumName")
                        .HasForeignKey("FixturesID");
                });

            modelBuilder.Entity("EPLDataSet.Models.Team", b =>
                {
                    b.HasOne("EPLDataSet.Models.Fixtures")
                        .WithMany("Team")
                        .HasForeignKey("FixturesID");

                    b.HasOne("EPLDataSet.Models.Manager", "Managers")
                        .WithMany()
                        .HasForeignKey("ManagersManagerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EPLDataSet.Models.TopGoalScorer", b =>
                {
                    b.HasOne("EPLDataSet.Models.Player", "FirstName")
                        .WithMany()
                        .HasForeignKey("FirstNamePlayerID");

                    b.HasOne("EPLDataSet.Models.Player", "LastName")
                        .WithMany()
                        .HasForeignKey("LastNamePlayerID");
                });
#pragma warning restore 612, 618
        }
    }
}
