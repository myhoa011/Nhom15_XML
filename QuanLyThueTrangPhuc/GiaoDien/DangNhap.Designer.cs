
namespace QuanLyThueTrangPhuc
{
    partial class DangNhap
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
            this.tb_TaiKhoan = new System.Windows.Forms.TextBox();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_DangNhap = new System.Windows.Forms.Button();
            this.cb_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(622, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_TaiKhoan
            // 
            this.tb_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TaiKhoan.ForeColor = System.Drawing.Color.Maroon;
            this.tb_TaiKhoan.Location = new System.Drawing.Point(600, 165);
            this.tb_TaiKhoan.Name = "tb_TaiKhoan";
            this.tb_TaiKhoan.Size = new System.Drawing.Size(284, 30);
            this.tb_TaiKhoan.TabIndex = 2;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MatKhau.ForeColor = System.Drawing.Color.Maroon;
            this.tb_MatKhau.Location = new System.Drawing.Point(600, 235);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(284, 30);
            this.tb_MatKhau.TabIndex = 4;
            this.tb_MatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bt_DangNhap
            // 
            this.bt_DangNhap.BackColor = System.Drawing.Color.SaddleBrown;
            this.bt_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_DangNhap.Location = new System.Drawing.Point(630, 356);
            this.bt_DangNhap.Name = "bt_DangNhap";
            this.bt_DangNhap.Size = new System.Drawing.Size(234, 47);
            this.bt_DangNhap.TabIndex = 5;
            this.bt_DangNhap.Text = "Đăng nhập";
            this.bt_DangNhap.UseVisualStyleBackColor = false;
            this.bt_DangNhap.Click += new System.EventHandler(this.bt_DangNhap_Click);
            // 
            // cb_HienMatKhau
            // 
            this.cb_HienMatKhau.AutoSize = true;
            this.cb_HienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.cb_HienMatKhau.ForeColor = System.Drawing.Color.Maroon;
            this.cb_HienMatKhau.Location = new System.Drawing.Point(744, 277);
            this.cb_HienMatKhau.Name = "cb_HienMatKhau";
            this.cb_HienMatKhau.Size = new System.Drawing.Size(140, 21);
            this.cb_HienMatKhau.TabIndex = 6;
            this.cb_HienMatKhau.Text = "Hiển thị mật khẩu";
            this.cb_HienMatKhau.UseVisualStyleBackColor = false;
            this.cb_HienMatKhau.CheckedChanged += new System.EventHandler(this.cb_HienMatKhau_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(704, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::QuanLyThueTrangPhuc.Properties.Resources.Neutral_Fashion_Mockup_Promotion_Facebook_Cover;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cb_HienMatKhau);
            this.Controls.Add(this.bt_DangNhap);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_TaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TaiKhoan;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_DangNhap;
        private System.Windows.Forms.CheckBox cb_HienMatKhau;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

