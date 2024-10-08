using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class initDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teeth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expiry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Labo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByLookupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByLookupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    State = table.Column<int>(type: "int", nullable: true),
                    Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: true),
                    RoleLookupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: true),
                    LastLoginDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByLookupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByLookupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    State = table.Column<int>(type: "int", nullable: true),
                    Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserEntity",
                columns: new[] { "Id", "Address", "CreateDate", "CreatedBy", "CreatedByLookupName", "Delete", "Email", "LastLoginDate", "ModifiedBy", "ModifiedByLookupName", "Name", "Password", "Phone", "Role", "RoleLookupName", "Sex", "State", "UpdateDate" },
                values: new object[] { new Guid("8669ff31-4c04-4bd7-bcb2-e4b2d4608cb3"), "143 Vũ Tông Phan, phường Khương Trung, quận Thanh Xuân, thành phố Hà Nội, Hanoi, Vietnam", new DateTimeOffset(new DateTime(2024, 10, 8, 22, 13, 36, 907, DateTimeKind.Unspecified).AddTicks(4516), new TimeSpan(0, 7, 0, 0, 0)), new Guid("eeb75e9b-100e-4d78-b8b1-a924dc7eb447"), null, false, "laviedental@admin.com", null, new Guid("eeb75e9b-100e-4d78-b8b1-a924dc7eb447"), null, "Admin", "BC89C73924089A668CE24F60232CA28C", "0944 66 6363", 0, null, 0, null, new DateTimeOffset(new DateTime(2024, 10, 8, 22, 13, 36, 907, DateTimeKind.Unspecified).AddTicks(4532), new TimeSpan(0, 7, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Informations");

            migrationBuilder.DropTable(
                name: "UserEntity");
        }
    }
}
