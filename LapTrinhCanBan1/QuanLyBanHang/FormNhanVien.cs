using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            NhanVien teo = new NhanVien()
            {
                Id = Guid.NewGuid(),
                Name = "Teo Nguyen",
                BOD = new DateTime(1990, 1, 1),
                DiaChi = "HCM",
                Email = "teonguyen@gmail.com",
                Phone = "0903565596",
                Password = "123456",
                Username = "teonv"
            };
            NhanVien ti = new NhanVien()
            {
                Id = Guid.NewGuid(),
                Name = "Ti Nguyen",
                BOD = new DateTime(1990, 1, 1),
                DiaChi = "HCM",
                Email = "tinguyen@gmail.com",
                Phone = "0903565596",
                Password = "123456",
                Username = "tinv"
            };
            string[] row =
            {
                ti.Id.ToString(),
                ti.Name,
                ti.BOD.ToString("dd-mm-yyyy"),
                ti.DiaChi,
                ti.Email,
                ti.Phone,
                ti.Password,
                ti.Username,

            };
            ///lsvDanhSachNhanVien.Item
            List<NhanVien> DSNhanVien = new List<NhanVien>();
            DSNhanVien.Add(ti);
            DSNhanVien.Add(teo);
            ListViewItem listViewItem = new ListViewItem();

            lsvDanhSachNhanVien.Items.Add(listViewItem);


        }


    }
}
