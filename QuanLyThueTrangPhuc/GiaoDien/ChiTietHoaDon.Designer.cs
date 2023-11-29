
namespace QuanLyThueTrangPhuc.GiaoDien
{
    partial class ChiTietHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_tenTP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_MaNV = new System.Windows.Forms.TextBox();
            this.gb_ThongTinHD = new System.Windows.Forms.GroupBox();
            this.bt_themTP = new System.Windows.Forms.Button();
            this.bt_LuuHD = new System.Windows.Forms.Button();
            this.tb_DonGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dt_NgayThue = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_SoLuongThue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_NgayTao = new System.Windows.Forms.DateTimePicker();
            this.bt_HoaDonMoi = new System.Windows.Forms.Button();
            this.GV_ChiTietHD = new System.Windows.Forms.DataGridView();
            this.gb_ThongTinHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(418, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã hóa đơn:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbMaHD
            // 
            this.tbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHD.Location = new System.Drawing.Point(173, 32);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(284, 28);
            this.tbMaHD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên khách hàng:";
            // 
            // tb_tenKH
            // 
            this.tb_tenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenKH.Location = new System.Drawing.Point(173, 89);
            this.tb_tenKH.Name = "tb_tenKH";
            this.tb_tenKH.Size = new System.Drawing.Size(284, 28);
            this.tb_tenKH.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày tạo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên trang phục:";
            // 
            // cbb_tenTP
            // 
            this.cbb_tenTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tenTP.FormattingEnabled = true;
            this.cbb_tenTP.Location = new System.Drawing.Point(173, 144);
            this.cbb_tenTP.Name = "cbb_tenTP";
            this.cbb_tenTP.Size = new System.Drawing.Size(284, 28);
            this.cbb_tenTP.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã nhân viên:";
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaNV.Location = new System.Drawing.Point(173, 199);
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.Size = new System.Drawing.Size(284, 28);
            this.tb_MaNV.TabIndex = 12;
            // 
            // gb_ThongTinHD
            // 
            this.gb_ThongTinHD.BackColor = System.Drawing.Color.Linen;
            this.gb_ThongTinHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gb_ThongTinHD.Controls.Add(this.tb_DonGia);
            this.gb_ThongTinHD.Controls.Add(this.label10);
            this.gb_ThongTinHD.Controls.Add(this.dt_NgayThue);
            this.gb_ThongTinHD.Controls.Add(this.label9);
            this.gb_ThongTinHD.Controls.Add(this.dt_NgayTra);
            this.gb_ThongTinHD.Controls.Add(this.label8);
            this.gb_ThongTinHD.Controls.Add(this.tb_SoLuongThue);
            this.gb_ThongTinHD.Controls.Add(this.label7);
            this.gb_ThongTinHD.Controls.Add(this.dt_NgayTao);
            this.gb_ThongTinHD.Controls.Add(this.tb_MaNV);
            this.gb_ThongTinHD.Controls.Add(this.label6);
            this.gb_ThongTinHD.Controls.Add(this.cbb_tenTP);
            this.gb_ThongTinHD.Controls.Add(this.label5);
            this.gb_ThongTinHD.Controls.Add(this.label4);
            this.gb_ThongTinHD.Controls.Add(this.tb_tenKH);
            this.gb_ThongTinHD.Controls.Add(this.label3);
            this.gb_ThongTinHD.Controls.Add(this.tbMaHD);
            this.gb_ThongTinHD.Controls.Add(this.label2);
            this.gb_ThongTinHD.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ThongTinHD.Location = new System.Drawing.Point(93, 107);
            this.gb_ThongTinHD.Name = "gb_ThongTinHD";
            this.gb_ThongTinHD.Size = new System.Drawing.Size(982, 312);
            this.gb_ThongTinHD.TabIndex = 2;
            this.gb_ThongTinHD.TabStop = false;
            this.gb_ThongTinHD.Text = "Thông tin hóa đơn";
            // 
            // bt_themTP
            // 
            this.bt_themTP.BackColor = System.Drawing.Color.Green;
            this.bt_themTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_themTP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_themTP.Location = new System.Drawing.Point(878, 419);
            this.bt_themTP.Name = "bt_themTP";
            this.bt_themTP.Size = new System.Drawing.Size(197, 53);
            this.bt_themTP.TabIndex = 25;
            this.bt_themTP.Text = "Thêm trang phục";
            this.bt_themTP.UseVisualStyleBackColor = false;
            this.bt_themTP.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_LuuHD
            // 
            this.bt_LuuHD.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_LuuHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LuuHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_LuuHD.Location = new System.Drawing.Point(512, 419);
            this.bt_LuuHD.Name = "bt_LuuHD";
            this.bt_LuuHD.Size = new System.Drawing.Size(111, 47);
            this.bt_LuuHD.TabIndex = 24;
            this.bt_LuuHD.Text = "Lưu";
            this.bt_LuuHD.UseVisualStyleBackColor = false;
            // 
            // tb_DonGia
            // 
            this.tb_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DonGia.Location = new System.Drawing.Point(678, 202);
            this.tb_DonGia.Name = "tb_DonGia";
            this.tb_DonGia.Size = new System.Drawing.Size(200, 28);
            this.tb_DonGia.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(571, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Đơn giá:";
            // 
            // dt_NgayThue
            // 
            this.dt_NgayThue.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NgayThue.Location = new System.Drawing.Point(678, 36);
            this.dt_NgayThue.Name = "dt_NgayThue";
            this.dt_NgayThue.Size = new System.Drawing.Size(200, 26);
            this.dt_NgayThue.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(567, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ngày thuê:";
            // 
            // dt_NgayTra
            // 
            this.dt_NgayTra.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NgayTra.Location = new System.Drawing.Point(678, 88);
            this.dt_NgayTra.Name = "dt_NgayTra";
            this.dt_NgayTra.Size = new System.Drawing.Size(200, 26);
            this.dt_NgayTra.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(567, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày trả:";
            // 
            // tb_SoLuongThue
            // 
            this.tb_SoLuongThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoLuongThue.Location = new System.Drawing.Point(710, 146);
            this.tb_SoLuongThue.Name = "tb_SoLuongThue";
            this.tb_SoLuongThue.Size = new System.Drawing.Size(168, 28);
            this.tb_SoLuongThue.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số lượng thuê:";
            // 
            // dt_NgayTao
            // 
            this.dt_NgayTao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NgayTao.Location = new System.Drawing.Point(173, 255);
            this.dt_NgayTao.Name = "dt_NgayTao";
            this.dt_NgayTao.Size = new System.Drawing.Size(284, 26);
            this.dt_NgayTao.TabIndex = 13;
            this.dt_NgayTao.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bt_HoaDonMoi
            // 
            this.bt_HoaDonMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_HoaDonMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HoaDonMoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_HoaDonMoi.Location = new System.Drawing.Point(88, 54);
            this.bt_HoaDonMoi.Name = "bt_HoaDonMoi";
            this.bt_HoaDonMoi.Size = new System.Drawing.Size(168, 47);
            this.bt_HoaDonMoi.TabIndex = 23;
            this.bt_HoaDonMoi.Text = "Hóa đơn mới";
            this.bt_HoaDonMoi.UseVisualStyleBackColor = false;
            // 
            // GV_ChiTietHD
            // 
            this.GV_ChiTietHD.BackgroundColor = System.Drawing.Color.White;
            this.GV_ChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ChiTietHD.Location = new System.Drawing.Point(93, 499);
            this.GV_ChiTietHD.MultiSelect = false;
            this.GV_ChiTietHD.Name = "GV_ChiTietHD";
            this.GV_ChiTietHD.ReadOnly = true;
            this.GV_ChiTietHD.RowHeadersWidth = 51;
            this.GV_ChiTietHD.RowTemplate.Height = 24;
            this.GV_ChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_ChiTietHD.Size = new System.Drawing.Size(982, 242);
            this.GV_ChiTietHD.TabIndex = 18;
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLyThueTrangPhuc.Properties.Resources.Neutral_Fashion_Mockup_Promotion_Facebook_Cover__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 753);
            this.Controls.Add(this.bt_themTP);
            this.Controls.Add(this.GV_ChiTietHD);
            this.Controls.Add(this.bt_LuuHD);
            this.Controls.Add(this.gb_ThongTinHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_HoaDonMoi);
            this.DoubleBuffered = true;
            this.Name = "ChiTietHoaDon";
            this.Text = "ChiTietHoaDon";
            this.gb_ThongTinHD.ResumeLayout(false);
            this.gb_ThongTinHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ChiTietHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_tenTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_MaNV;
        private System.Windows.Forms.GroupBox gb_ThongTinHD;
        private System.Windows.Forms.DateTimePicker dt_NgayTao;
        private System.Windows.Forms.TextBox tb_DonGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dt_NgayThue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_NgayTra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_SoLuongThue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_themTP;
        private System.Windows.Forms.Button bt_LuuHD;
        private System.Windows.Forms.Button bt_HoaDonMoi;
        private System.Windows.Forms.DataGridView GV_ChiTietHD;
    }
}