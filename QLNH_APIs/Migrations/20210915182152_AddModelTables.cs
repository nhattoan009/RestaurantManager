using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLNH_APIs.Migrations
{
    public partial class AddModelTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "Category",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         parentId = table.Column<int>(type: "int", nullable: false),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Deleted = table.Column<bool>(type: "bit", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Category", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Guest",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Deleted = table.Column<bool>(type: "bit", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Guest", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Order",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         OrderNumber = table.Column<int>(type: "int", nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Deleted = table.Column<bool>(type: "bit", nullable: false),
            //         voided = table.Column<bool>(type: "bit", nullable: false),
            //         TotalPrice = table.Column<double>(type: "float", nullable: false),
            //         PaiAmount = table.Column<double>(type: "float", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Order", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Role",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Deleted = table.Column<bool>(type: "bit", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Role", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Status",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Deleted = table.Column<bool>(type: "bit", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Status", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "UnitType",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Deleted = table.Column<bool>(type: "bit", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_UnitType", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "UserModel",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_UserModel", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "GuestTable",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Deleted = table.Column<bool>(type: "bit", nullable: false),
            //         Statusid = table.Column<int>(type: "int", nullable: true),
            //         Guestid = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_GuestTable", x => x.id);
            //         table.ForeignKey(
            //             name: "FK_GuestTable_Guest_Guestid",
            //             column: x => x.Guestid,
            //             principalTable: "Guest",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Restrict);
            //         table.ForeignKey(
            //             name: "FK_GuestTable_Status_Statusid",
            //             column: x => x.Statusid,
            //             principalTable: "Status",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Restrict);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Unit",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Deleted = table.Column<bool>(type: "bit", nullable: false),
            //         UnitTypeid = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Unit", x => x.id);
            //         table.ForeignKey(
            //             name: "FK_Unit_UnitType_UnitTypeid",
            //             column: x => x.UnitTypeid,
            //             principalTable: "UnitType",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Restrict);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Item",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Price = table.Column<double>(type: "float", nullable: false),
            //         Discount = table.Column<double>(type: "float", nullable: false),
            //         Quantity = table.Column<int>(type: "int", nullable: false),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Deleted = table.Column<bool>(type: "bit", nullable: false),
            //         Unitid = table.Column<int>(type: "int", nullable: true),
            //         Categoryid = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Item", x => x.id);
            //         table.ForeignKey(
            //             name: "FK_Item_Category_Categoryid",
            //             column: x => x.Categoryid,
            //             principalTable: "Category",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Restrict);
            //         table.ForeignKey(
            //             name: "FK_Item_Unit_Unitid",
            //             column: x => x.Unitid,
            //             principalTable: "Unit",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Restrict);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "ItemImage",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Deleted = table.Column<bool>(type: "bit", nullable: false),
            //         Itemid = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_ItemImage", x => x.id);
            //         table.ForeignKey(
            //             name: "FK_ItemImage_Item_Itemid",
            //             column: x => x.Itemid,
            //             principalTable: "Item",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Restrict);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "OrderItem",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //         Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //         Deleted = table.Column<bool>(type: "bit", nullable: false),
            //         voided = table.Column<bool>(type: "bit", nullable: false),
            //         SalePrice = table.Column<double>(type: "float", nullable: false),
            //         Itemid = table.Column<int>(type: "int", nullable: true),
            //         Orderid = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_OrderItem", x => x.id);
            //         table.ForeignKey(
            //             name: "FK_OrderItem_Item_Itemid",
            //             column: x => x.Itemid,
            //             principalTable: "Item",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Restrict);
            //         table.ForeignKey(
            //             name: "FK_OrderItem_Order_Orderid",
            //             column: x => x.Orderid,
            //             principalTable: "Order",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Restrict);
            //     });

            // migrationBuilder.CreateIndex(
            //     name: "IX_GuestTable_Guestid",
            //     table: "GuestTable",
            //     column: "Guestid");

            // migrationBuilder.CreateIndex(
            //     name: "IX_GuestTable_Statusid",
            //     table: "GuestTable",
            //     column: "Statusid");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Item_Categoryid",
            //     table: "Item",
            //     column: "Categoryid");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Item_Unitid",
            //     table: "Item",
            //     column: "Unitid");

            // migrationBuilder.CreateIndex(
            //     name: "IX_ItemImage_Itemid",
            //     table: "ItemImage",
            //     column: "Itemid");

            // migrationBuilder.CreateIndex(
            //     name: "IX_OrderItem_Itemid",
            //     table: "OrderItem",
            //     column: "Itemid");

            // migrationBuilder.CreateIndex(
            //     name: "IX_OrderItem_Orderid",
            //     table: "OrderItem",
            //     column: "Orderid");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Unit_UnitTypeid",
            //     table: "Unit",
            //     column: "UnitTypeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "GuestTable");

            // migrationBuilder.DropTable(
            //     name: "ItemImage");

            // migrationBuilder.DropTable(
            //     name: "OrderItem");

            // migrationBuilder.DropTable(
            //     name: "Role");

            // migrationBuilder.DropTable(
            //     name: "UserModel");

            // migrationBuilder.DropTable(
            //     name: "Guest");

            // migrationBuilder.DropTable(
            //     name: "Status");

            // migrationBuilder.DropTable(
            //     name: "Item");

            // migrationBuilder.DropTable(
            //     name: "Order");

            // migrationBuilder.DropTable(
            //     name: "Category");

            // migrationBuilder.DropTable(
            //     name: "Unit");

            // migrationBuilder.DropTable(
            //     name: "UnitType");
        }
    }
}
