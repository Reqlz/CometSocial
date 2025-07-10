using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CometSocial.Migrations
{
    /// <inheritdoc />
    public partial class CometSocial_Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CometGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CometGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CometInteractions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InteractionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CometInteractions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CometInteractionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CometInteractionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CometUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CometUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CometFollowers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFollowToId = table.Column<int>(type: "int", nullable: false),
                    UserFollowFromId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CometFollowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CometFollowers_CometUsers_UserFollowFromId",
                        column: x => x.UserFollowFromId,
                        principalTable: "CometUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CometFollowers_CometUsers_UserFollowToId",
                        column: x => x.UserFollowToId,
                        principalTable: "CometUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CometPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CometPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CometPosts_CometUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "CometUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CometUsersGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CometUsersGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CometUsersGroups_CometGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "CometGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CometUsersGroups_CometUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "CometUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CometPostsInteractions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    InteractionId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CometPostsInteractions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CometPostsInteractions_CometInteractions_InteractionId",
                        column: x => x.InteractionId,
                        principalTable: "CometInteractions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CometPostsInteractions_CometPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "CometPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CometFollowers_UserFollowFromId",
                table: "CometFollowers",
                column: "UserFollowFromId");

            migrationBuilder.CreateIndex(
                name: "IX_CometFollowers_UserFollowToId",
                table: "CometFollowers",
                column: "UserFollowToId");

            migrationBuilder.CreateIndex(
                name: "IX_CometPosts_UserId",
                table: "CometPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CometPostsInteractions_InteractionId",
                table: "CometPostsInteractions",
                column: "InteractionId");

            migrationBuilder.CreateIndex(
                name: "IX_CometPostsInteractions_PostId",
                table: "CometPostsInteractions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_CometUsersGroups_GroupId",
                table: "CometUsersGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CometUsersGroups_UserId",
                table: "CometUsersGroups",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CometFollowers");

            migrationBuilder.DropTable(
                name: "CometInteractionTypes");

            migrationBuilder.DropTable(
                name: "CometPostsInteractions");

            migrationBuilder.DropTable(
                name: "CometUsersGroups");

            migrationBuilder.DropTable(
                name: "CometInteractions");

            migrationBuilder.DropTable(
                name: "CometPosts");

            migrationBuilder.DropTable(
                name: "CometGroups");

            migrationBuilder.DropTable(
                name: "CometUsers");
        }
    }
}
