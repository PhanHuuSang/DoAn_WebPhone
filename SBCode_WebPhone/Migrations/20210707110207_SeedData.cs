using Microsoft.EntityFrameworkCore.Migrations;
using SBCode_WebPhone.Helper;

namespace SBCode_WebPhone.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {



            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleName", "IsSystem" },
                values: new object[] { "Quản Trị", true });
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleName", "IsSystem" },
                values: new object[] { "Bán Hàng", true });
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleName", "IsSystem" },
                values: new object[] { "Thủ Kho", true });
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleName", "IsSystem" },
                values: new object[] { "Khách Hàng", true });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "MaKh", "DangHoatDong", "DiaChi", "Email", "HoTen", "MaNgauNhien", "MatKhau", "SoDienThoai" },
                values: new object[] { 1, true, "GiaLai", "admin@gmail.com", "Admin", "01", "admin".ToSHA512Hash("01"), "0868811469" });

            migrationBuilder.InsertData(
               table: "UserRole",
               columns: new[] { "RoleId", "UserId" },
               values: new object[] { 1, 1});


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "KhachHang",
            //    keyColumn: "MaKh",
            //    keyValue: 1);
        }
    }
}
