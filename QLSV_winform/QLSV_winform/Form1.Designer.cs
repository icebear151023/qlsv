namespace QLSV_winform
{
    partial class trang_chu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btn_login = new Button();
            btn_dangky = new Button();
            btn_tt = new Button();
            button4 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(727, 114);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sinh viên";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(142, 328);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(115, 38);
            btn_login.TabIndex = 1;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_dangky
            // 
            btn_dangky.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dangky.Location = new Point(142, 387);
            btn_dangky.Name = "btn_dangky";
            btn_dangky.Size = new Size(115, 38);
            btn_dangky.TabIndex = 2;
            btn_dangky.Text = "Đăng ký";
            btn_dangky.UseVisualStyleBackColor = true;
            btn_dangky.Click += btn_dangky_Click;
            // 
            // btn_tt
            // 
            btn_tt.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_tt.Location = new Point(520, 328);
            btn_tt.Name = "btn_tt";
            btn_tt.Size = new Size(115, 38);
            btn_tt.TabIndex = 3;
            btn_tt.Text = "Thông tin";
            btn_tt.UseVisualStyleBackColor = true;
            btn_tt.Click += btn_tt_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(520, 387);
            button4.Name = "button4";
            button4.Size = new Size(115, 38);
            button4.TabIndex = 4;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-3, 39);
            label2.Name = "label2";
            label2.Size = new Size(490, 31);
            label2.TabIndex = 5;
            label2.Text = "Trường Đại Học Kinh Tế Kỹ Thuật Công Nghiệp";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 178);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(142, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 96);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_1;
            // 
            // trang_chu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(btn_tt);
            Controls.Add(btn_dangky);
            Controls.Add(btn_login);
            Name = "trang_chu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_login;
        private Button btn_dangky;
        private Button btn_tt;
        private Button button4;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
    }
}
