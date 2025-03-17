﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookify.Web.Data.Migrations
{
	/// <inheritdoc />
	public partial class AddIndexToApplicationUserTable : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateIndex(
				name: "IX_AspNetUsers_Email",
				table: "AspNetUsers",
				column: "Email",
				unique: true,
				filter: "[Email] IS NOT NULL");

			migrationBuilder.CreateIndex(
				name: "IX_AspNetUsers_FullName",
				table: "AspNetUsers",
				column: "FullName",
				unique: true);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropIndex(
				name: "IX_AspNetUsers_Email",
				table: "AspNetUsers");

			migrationBuilder.DropIndex(
				name: "IX_AspNetUsers_FullName",
				table: "AspNetUsers");
		}
	}
}
