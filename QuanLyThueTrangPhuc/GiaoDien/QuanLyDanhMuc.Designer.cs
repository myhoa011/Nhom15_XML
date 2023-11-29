
namespace QuanLyThueTrangPhuc.GiaoDien
{
    partial class QuanLyDanhMuc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MatKhauCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GV_DanhMuc = new System.Windows.Forms.DataGridView();
            this.bt_ThemDM = new System.Windows.Forms.Button();
            this.bt_XoaDM = new System.Windows.Forms.Button();
            this.bt_SuaDM = new System.Windows.Forms.Button();
            this.bt_LMoiDanhMuc = new System.Windows.Forms.Button();
            this.bt_TKDanhMuc = new System.Windows.Forms.Button();
            this.tb_MaDanhMuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_HuyDM = new System.Windows.Forms.Button();
            this.bt_LuuDM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản lý danh mục";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tb_MatKhauMoi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_MatKhauCu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(112, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 211);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin danh mục";
            // 
            // tb_MatKhauMoi
            // 
            this.tb_MatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MatKhauMoi.Location = new System.Drawing.Point(369, 112);
            this.tb_MatKhauMoi.Name = "tb_MatKhauMoi";
            this.tb_MatKhauMoi.Size = new System.Drawing.Size(284, 30);
            this.tb_MatKhauMoi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên danh mục";
            // 
            // tb_MatKhauCu
            // 
            this.tb_MatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MatKhauCu.Location = new System.Drawing.Point(369, 54);
            this.tb_MatKhauCu.Name = "tb_MatKhauCu";
            this.tb_MatKhauCu.Size = new System.Drawing.Size(284, 30);
            this.tb_MatKhauCu.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã danh mục:";
            // 
            // GV_DanhMuc
            // 
            this.GV_DanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.GV_DanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_DanhMuc.Location = new System.Drawing.Point(112, 479);
            this.GV_DanhMuc.MultiSelect = false;
            this.GV_DanhMuc.Name = "GV_DanhMuc";
            this.GV_DanhMuc.ReadOnly = true;
            this.GV_DanhMuc.RowHeadersWidth = 51;
            this.GV_DanhMuc.RowTemplate.Height = 24;
            this.GV_DanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_DanhMuc.Size = new System.Drawing.Size(957, 242);
            this.GV_DanhMuc.TabIndex = 29;
            // 
            // bt_ThemDM
            // 
            this.bt_ThemDM.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_ThemDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThemDM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ThemDM.Location = new System.Drawing.Point(958, 209);
            this.bt_ThemDM.Name = "bt_ThemDM";
            this.bt_ThemDM.Size = new System.Drawing.Size(111, 47);
            this.bt_ThemDM.TabIndex = 30;
            this.bt_ThemDM.Text = "Thêm";
            this.bt_ThemDM.UseVisualStyleBackColor = false;
            // 
            // bt_XoaDM
            // 
            this.bt_XoaDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_XoaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_XoaDM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_XoaDM.Location = new System.Drawing.Point(958, 373);
            this.bt_XoaDM.Name = "bt_XoaDM";
            this.bt_XoaDM.Size = new System.Drawing.Size(111, 47);
            this.bt_XoaDM.TabIndex = 31;
            this.bt_XoaDM.Text = "Xóa";
            this.bt_XoaDM.UseVisualStyleBackColor = false;
            // 
            // bt_SuaDM
            // 
            this.bt_SuaDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_SuaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SuaDM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_SuaDM.Location = new System.Drawing.Point(958, 291);
            this.bt_SuaDM.Name = "bt_SuaDM";
            this.bt_SuaDM.Size = new System.Drawing.Size(111, 47);
            this.bt_SuaDM.TabIndex = 32;
            this.bt_SuaDM.Text = "Sửa";
            this.bt_SuaDM.UseVisualStyleBackColor = false;
            // 
            // bt_LMoiDanhMuc
            // 
            this.bt_LMoiDanhMuc.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.bt_LMoiDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LMoiDanhMuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_LMoiDanhMuc.Location = new System.Drawing.Point(694, 162);
            this.bt_LMoiDanhMuc.Name = "bt_LMoiDanhMuc";
            this.bt_LMoiDanhMuc.Size = new System.Drawing.Size(98, 41);
            this.bt_LMoiDanhMuc.TabIndex = 36;
            this.bt_LMoiDanhMuc.Text = "Làm mới";
            this.bt_LMoiDanhMuc.UseVisualStyleBackColor = false;
            // 
            // bt_TKDanhMuc
            // 
            this.bt_TKDanhMuc.BackColor = System.Drawing.Color.SaddleBrown;
            this.bt_TKDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TKDanhMuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_TKDanhMuc.Location = new System.Drawing.Point(538, 162);
            this.bt_TKDanhMuc.Name = "bt_TKDanhMuc";
            this.bt_TKDanhMuc.Size = new System.Drawing.Size(150, 41);
            this.bt_TKDanhMuc.TabIndex = 35;
            this.bt_TKDanhMuc.Text = "Tìm kiếm";
            this.bt_TKDanhMuc.UseVisualStyleBackColor = false;
            // 
            // tb_MaDanhMuc
            // 
            this.tb_MaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaDanhMuc.Location = new System.Drawing.Point(248, 168);
            this.tb_MaDanhMuc.Name = "tb_MaDanhMuc";
            this.tb_MaDanhMuc.Size = new System.Drawing.Size(284, 28);
            this.tb_MaDanhMuc.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mã danh mục:";
            // 
            // bt_HuyDM
            // 
            this.bt_HuyDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_HuyDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HuyDM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_HuyDM.Location = new System.Drawing.Point(603, 426);
            this.bt_HuyDM.Name = "bt_HuyDM";
            this.bt_HuyDM.Size = new System.Drawing.Size(111, 47);
            this.bt_HuyDM.TabIndex = 38;
            this.bt_HuyDM.Text = "Hủy";
            this.bt_HuyDM.UseVisualStyleBackColor = false;
            // 
            // bt_LuuDM
            // 
            this.bt_LuuDM.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_LuuDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LuuDM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_LuuDM.Location = new System.Drawing.Point(481, 426);
            this.bt_LuuDM.Name = "bt_LuuDM";
            this.bt_LuuDM.Size = new System.Drawing.Size(111, 47);
            this.bt_LuuDM.TabIndex = 37;
            this.bt_LuuDM.Text = "Lưu";
            this.bt_LuuDM.UseVisualStyleBackColor = false;
            // 
            // QuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThueTrangPhuc.Properties.Resources.Neutral_Fashion_Mockup_Promotion_Facebook_Cover__2_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 753);
            this.Controls.Add(this.bt_HuyDM);
            this.Controls.Add(this.bt_LuuDM);
            this.Controls.Add(this.bt_LMoiDanhMuc);
            this.Controls.Add(this.bt_TKDanhMuc);
            this.Controls.Add(this.tb_MaDanhMuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_SuaDM);
            this.Controls.Add(this.bt_XoaDM);
            this.Controls.Add(this.bt_ThemDM);
            this.Controls.Add(this.GV_DanhMuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "QuanLyDanhMuc";
            this.Text = "QuanLyDanhMuc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_MatKhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_MatKhauCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GV_DanhMuc;
        private System.Windows.Forms.Button bt_ThemDM;
        private System.Windows.Forms.Button bt_XoaDM;
        private System.Windows.Forms.Button bt_SuaDM;
        private System.Windows.Forms.Button bt_LMoiDanhMuc;
        private System.Windows.Forms.Button bt_TKDanhMuc;
        private System.Windows.Forms.TextBox tb_MaDanhMuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_HuyDM;
        private System.Windows.Forms.Button bt_LuuDM;
    }
}