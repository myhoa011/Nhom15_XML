
namespace QuanLyThueTrangPhuc.GiaoDien
{
    partial class QuanLyHoaDon
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
            this.tbMaHD_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GV_HD = new System.Windows.Forms.DataGridView();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.bt_LamMoi = new System.Windows.Forms.Button();
            this.bt_TaoHD = new System.Windows.Forms.Button();
            this.GV_ChitietHDQL = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_InHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ChitietHDQL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(433, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý hóa đơn";
            // 
            // tbMaHD_search
            // 
            this.tbMaHD_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHD_search.Location = new System.Drawing.Point(224, 104);
            this.tbMaHD_search.Name = "tbMaHD_search";
            this.tbMaHD_search.Size = new System.Drawing.Size(284, 28);
            this.tbMaHD_search.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // GV_HD
            // 
            this.GV_HD.BackgroundColor = System.Drawing.Color.White;
            this.GV_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_HD.Location = new System.Drawing.Point(91, 145);
            this.GV_HD.MultiSelect = false;
            this.GV_HD.Name = "GV_HD";
            this.GV_HD.ReadOnly = true;
            this.GV_HD.RowHeadersWidth = 51;
            this.GV_HD.RowTemplate.Height = 24;
            this.GV_HD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_HD.Size = new System.Drawing.Size(982, 242);
            this.GV_HD.TabIndex = 19;
            this.GV_HD.SelectionChanged += new System.EventHandler(this.GV_HD_SelectionChanged);
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.BackColor = System.Drawing.Color.SaddleBrown;
            this.bt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_TimKiem.Location = new System.Drawing.Point(514, 98);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(150, 41);
            this.bt_TimKiem.TabIndex = 25;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // bt_LamMoi
            // 
            this.bt_LamMoi.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.bt_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LamMoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_LamMoi.Location = new System.Drawing.Point(670, 98);
            this.bt_LamMoi.Name = "bt_LamMoi";
            this.bt_LamMoi.Size = new System.Drawing.Size(101, 41);
            this.bt_LamMoi.TabIndex = 26;
            this.bt_LamMoi.Text = "Làm mới";
            this.bt_LamMoi.UseVisualStyleBackColor = false;
            this.bt_LamMoi.Click += new System.EventHandler(this.bt_LamMoi_Click);
            // 
            // bt_TaoHD
            // 
            this.bt_TaoHD.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_TaoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TaoHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_TaoHD.Location = new System.Drawing.Point(923, 98);
            this.bt_TaoHD.Name = "bt_TaoHD";
            this.bt_TaoHD.Size = new System.Drawing.Size(150, 41);
            this.bt_TaoHD.TabIndex = 27;
            this.bt_TaoHD.Text = "Tạo hóa đơn";
            this.bt_TaoHD.UseVisualStyleBackColor = false;
            this.bt_TaoHD.Click += new System.EventHandler(this.bt_TaoHD_Click);
            // 
            // GV_ChitietHDQL
            // 
            this.GV_ChitietHDQL.BackgroundColor = System.Drawing.Color.White;
            this.GV_ChitietHDQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ChitietHDQL.Location = new System.Drawing.Point(91, 441);
            this.GV_ChitietHDQL.MultiSelect = false;
            this.GV_ChitietHDQL.Name = "GV_ChitietHDQL";
            this.GV_ChitietHDQL.ReadOnly = true;
            this.GV_ChitietHDQL.RowHeadersWidth = 51;
            this.GV_ChitietHDQL.RowTemplate.Height = 24;
            this.GV_ChitietHDQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_ChitietHDQL.Size = new System.Drawing.Size(982, 242);
            this.GV_ChitietHDQL.TabIndex = 28;
            this.GV_ChitietHDQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(468, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 36);
            this.label3.TabIndex = 29;
            this.label3.Text = "Chi tiết hóa đơn";
            // 
            // bt_InHD
            // 
            this.bt_InHD.BackColor = System.Drawing.Color.DarkGreen;
            this.bt_InHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_InHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_InHD.Location = new System.Drawing.Point(923, 689);
            this.bt_InHD.Name = "bt_InHD";
            this.bt_InHD.Size = new System.Drawing.Size(150, 41);
            this.bt_InHD.TabIndex = 30;
            this.bt_InHD.Text = "In hóa đơn";
            this.bt_InHD.UseVisualStyleBackColor = false;
            this.bt_InHD.Click += new System.EventHandler(this.bt_InHD_Click);
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThueTrangPhuc.Properties.Resources.Neutral_Fashion_Mockup_Promotion_Facebook_Cover__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 753);
            this.Controls.Add(this.bt_InHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GV_ChitietHDQL);
            this.Controls.Add(this.bt_TaoHD);
            this.Controls.Add(this.bt_LamMoi);
            this.Controls.Add(this.bt_TimKiem);
            this.Controls.Add(this.GV_HD);
            this.Controls.Add(this.tbMaHD_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "QuanLyHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ChitietHDQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaHD_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GV_HD;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.Button bt_LamMoi;
        private System.Windows.Forms.Button bt_TaoHD;
        private System.Windows.Forms.DataGridView GV_ChitietHDQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_InHD;
    }
}