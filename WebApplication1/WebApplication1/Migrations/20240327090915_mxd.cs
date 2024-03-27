using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class mxd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketPosition_Product_ProductID",
                table: "BasketPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketPosition_Users_UserID",
                table: "BasketPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Users_UserID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPosition_Order_OrderID",
                table: "OrderPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPosition_Product_ProductID",
                table: "OrderPosition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderPosition",
                table: "OrderPosition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketPosition",
                table: "BasketPosition");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "OrderPosition",
                newName: "OrderPositions");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "BasketPosition",
                newName: "BasketPositions");

            migrationBuilder.RenameIndex(
                name: "IX_OrderPosition_ProductID",
                table: "OrderPositions",
                newName: "IX_OrderPositions_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderPosition_OrderID",
                table: "OrderPositions",
                newName: "IX_OrderPositions_OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserID",
                table: "Orders",
                newName: "IX_Orders_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_BasketPosition_UserID",
                table: "BasketPositions",
                newName: "IX_BasketPositions_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_BasketPosition_ProductID",
                table: "BasketPositions",
                newName: "IX_BasketPositions_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderPositions",
                table: "OrderPositions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketPositions",
                table: "BasketPositions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPositions_Products_ProductID",
                table: "BasketPositions",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPositions_Users_UserID",
                table: "BasketPositions",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPositions_Orders_OrderID",
                table: "OrderPositions",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPositions_Products_ProductID",
                table: "OrderPositions",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserID",
                table: "Orders",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketPositions_Products_ProductID",
                table: "BasketPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketPositions_Users_UserID",
                table: "BasketPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPositions_Orders_OrderID",
                table: "OrderPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPositions_Products_ProductID",
                table: "OrderPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserID",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderPositions",
                table: "OrderPositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketPositions",
                table: "BasketPositions");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderPositions",
                newName: "OrderPosition");

            migrationBuilder.RenameTable(
                name: "BasketPositions",
                newName: "BasketPosition");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserID",
                table: "Order",
                newName: "IX_Order_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderPositions_ProductID",
                table: "OrderPosition",
                newName: "IX_OrderPosition_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderPositions_OrderID",
                table: "OrderPosition",
                newName: "IX_OrderPosition_OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_BasketPositions_UserID",
                table: "BasketPosition",
                newName: "IX_BasketPosition_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_BasketPositions_ProductID",
                table: "BasketPosition",
                newName: "IX_BasketPosition_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderPosition",
                table: "OrderPosition",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketPosition",
                table: "BasketPosition",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPosition_Product_ProductID",
                table: "BasketPosition",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPosition_Users_UserID",
                table: "BasketPosition",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Users_UserID",
                table: "Order",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPosition_Order_OrderID",
                table: "OrderPosition",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPosition_Product_ProductID",
                table: "OrderPosition",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
