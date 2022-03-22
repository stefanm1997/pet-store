using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.EFCore.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetToys_Orders_OrderId",
                table: "PetToys");

            migrationBuilder.DropIndex(
                name: "IX_PetToys_OrderId",
                table: "PetToys");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "PetToys");

            migrationBuilder.CreateTable(
                name: "OrderPetToy",
                columns: table => new
                {
                    OrdersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetToysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPetToy", x => new { x.OrdersId, x.PetToysId });
                    table.ForeignKey(
                        name: "FK_OrderPetToy_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPetToy_PetToys_PetToysId",
                        column: x => x.PetToysId,
                        principalTable: "PetToys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderPetToy_PetToysId",
                table: "OrderPetToy",
                column: "PetToysId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderPetToy");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "PetToys",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PetToys_OrderId",
                table: "PetToys",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PetToys_Orders_OrderId",
                table: "PetToys",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
