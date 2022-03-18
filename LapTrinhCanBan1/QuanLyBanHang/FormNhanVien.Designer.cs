namespace QuanLyBanHang
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvDanhSachNhanVien = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsvDanhSachNhanVien
            // 
            this.lsvDanhSachNhanVien.HideSelection = false;
            this.lsvDanhSachNhanVien.Location = new System.Drawing.Point(360, 26);
            this.lsvDanhSachNhanVien.Name = "lsvDanhSachNhanVien";
            this.lsvDanhSachNhanVien.Size = new System.Drawing.Size(428, 386);
            this.lsvDanhSachNhanVien.TabIndex = 0;
            this.lsvDanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachNhanVien.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachNhanVien_SelectedIndexChanged);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvDanhSachNhanVien);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvDanhSachNhanVien;
    }
}