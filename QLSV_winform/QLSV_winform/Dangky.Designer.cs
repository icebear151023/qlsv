namespace QLSV_winform
{
    partial class Dangky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangky));
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_username = new TextBox();
            txt_pass = new TextBox();
            txt_repass = new TextBox();
            bt_ok = new Button();
            bt_thoat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 23);
            label1.Name = "label1";
            label1.Size = new Size(133, 39);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(428, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 71);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 224);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(428, 94);
            label2.Name = "label2";
            label2.Size = new Size(133, 22);
            label2.TabIndex = 3;
            label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(428, 163);
            label3.Name = "label3";
            label3.Size = new Size(87, 22);
            label3.TabIndex = 4;
            label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(428, 230);
            label4.Name = "label4";
            label4.Size = new Size(165, 22);
            label4.TabIndex = 5;
            label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(428, 119);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(324, 30);
            txt_username.TabIndex = 6;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(428, 188);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(324, 27);
            txt_pass.TabIndex = 7;
            // 
            // txt_repass
            // 
            txt_repass.Location = new Point(428, 255);
            txt_repass.Name = "txt_repass";
            txt_repass.PasswordChar = '*';
            txt_repass.Size = new Size(324, 27);
            txt_repass.TabIndex = 8;
            // 
            // bt_ok
            // 
            bt_ok.Location = new Point(440, 300);
            bt_ok.Name = "bt_ok";
            bt_ok.Size = new Size(94, 29);
            bt_ok.TabIndex = 9;
            bt_ok.Text = "Đăng ký";
            bt_ok.UseVisualStyleBackColor = true;
            bt_ok.Click += bt_ok_Click;
            // 
            // bt_thoat
            // 
            bt_thoat.Location = new Point(645, 300);
            bt_thoat.Name = "bt_thoat";
            bt_thoat.Size = new Size(94, 29);
            bt_thoat.TabIndex = 10;
            bt_thoat.Text = "&Thoát";
            bt_thoat.UseVisualStyleBackColor = true;
            bt_thoat.Click += bt_thoat_Click;
            // 
            // Dangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 350);
            Controls.Add(bt_thoat);
            Controls.Add(bt_ok);
            Controls.Add(txt_repass);
            Controls.Add(txt_pass);
            Controls.Add(txt_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "Dangky";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dangky";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_username;
        private TextBox txt_pass;
        private TextBox txt_repass;
        private Button bt_ok;
        private Button bt_thoat;
    }
}