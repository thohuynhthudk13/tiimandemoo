using Microsoft.EntityFrameworkCore.Migrations;

namespace timan.api.Migrations
{
    public partial class initil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Giày da nam" },
                    { 2, "Giày thể thao nữ" }
                });

            migrationBuilder.InsertData(
                table: "productLists",
                columns: new[] { "ProductID", "CategoryID", "Desc1", "Desc2", "Desc3", "Desc4", "Photo", "Price", "ProductName", "Rate", "Sold", "Status" },
                values: new object[,]
                {
                    { 1, 1, "Hỗ trợ đổi size miễn phí", "Bảo hành từ 1 đến 5 năm", "Giao hàng nhanh toàn quốc", "Bộ sản phẩm bao gồm: Hộp, Giấy Lót, Thẻ Bảo Hành, Thẻ Hướng Dẫn Bảo Quản", "images/giaydanam.png", "550.038", "Giày Da Nam Đế Bằng MH19", 342, 432, "Còn hàng" },
                    { 2, 2, "Hỗ trợ đổi size miễn phí", "Bảo hành từ 1 đến 5 năm", "Giao hàng nhanh toàn quốc", "Bộ sản phẩm bao gồm: Hộp, Giấy Lót, Thẻ Bảo Hành, Thẻ Hướng Dẫn Bảo Quản", "images/giaythethonu.jpg", "550.038", "Giày thể thao nữ", 283, 533, "Còn hàng" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "productLists",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "productLists",
                keyColumn: "ProductID",
                keyValue: 2);
        }
    }
}
