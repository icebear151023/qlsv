namespace QLSV_winform
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_tk = new TextBox();
            txt_mk = new TextBox();
            btn_ok = new Button();
            btn_thoat = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 23);
            label1.Name = "label1";
            label1.Size = new Size(165, 41);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 126);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 190);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // txt_tk
            // 
            txt_tk.Location = new Point(369, 149);
            txt_tk.Name = "txt_tk";
            txt_tk.Size = new Size(429, 27);
            txt_tk.TabIndex = 3;
            txt_tk.KeyDown += txt_tk_KeyDown;
            // 
            // txt_mk
            // 
            txt_mk.Location = new Point(369, 213);
            txt_mk.Name = "txt_mk";
            txt_mk.PasswordChar = '*';
            txt_mk.Size = new Size(429, 27);
            txt_mk.TabIndex = 4;
            txt_mk.KeyDown += txt_mk_KeyDown;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(436, 260);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(112, 37);
            btn_ok.TabIndex = 5;
            btn_ok.Text = "Đăng nhập";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            btn_ok.KeyDown += btn_ok_KeyDown;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(603, 260);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(112, 37);
            btn_thoat.TabIndex = 6;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 214);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(342, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 83);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 313);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 9;
            label4.Text = "Bạn chưa có tài khoản?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(628, 313);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 20);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng ký";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 360);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_thoat);
            Controls.Add(btn_ok);
            Controls.Add(txt_mk);
            Controls.Add(txt_tk);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dangnhap";
            Load += Dangnhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_tk;
        private TextBox txt_mk;
        private Button btn_ok;
        private Button btn_thoat;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}