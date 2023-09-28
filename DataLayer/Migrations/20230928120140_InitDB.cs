﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
				name: "Books",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Isbn = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
					Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
					Genre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
					Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
					Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
					IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Books", x => x.Id);
				});

			migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
