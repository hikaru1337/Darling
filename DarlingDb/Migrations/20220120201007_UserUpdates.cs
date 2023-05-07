﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DarlingDb.Migrations
{
    public partial class UserUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_UsersMId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UsersMId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UsersMId1",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Users",
                newName: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UsersMId",
                table: "Users",
                column: "UsersMId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_UsersMId",
                table: "Users",
                column: "UsersMId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_UsersMId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UsersMId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "UsersId");

            migrationBuilder.AddColumn<ulong>(
                name: "UsersMId1",
                table: "Users",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UsersMId1",
                table: "Users",
                column: "UsersMId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_UsersMId1",
                table: "Users",
                column: "UsersMId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}