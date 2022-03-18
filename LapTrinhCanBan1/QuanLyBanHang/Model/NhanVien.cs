using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBanHang
{
    class NhanVien
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BOD { get; set; }
        // bod BIRRTHDAY
        public string DiaChi { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
