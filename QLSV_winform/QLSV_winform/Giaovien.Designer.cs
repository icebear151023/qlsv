namespace QLSV_winform
{
    partial class Giaovien
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txt_mk = new TextBox();
            txt_tdn = new TextBox();
            btn_dong = new Button();
            bt_nhaplai = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(646, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(378, 222);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_mk);
            groupBox1.Controls.Add(txt_tdn);
            groupBox1.Controls.Add(btn_dong);
            groupBox1.Controls.Add(bt_nhaplai);
            groupBox1.Controls.Add(btn_xoa);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(9, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 232);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tài khoản";
            // 
            // txt_mk
            // 
            txt_mk.Location = new Point(152, 89);
            txt_mk.Name = "txt_mk";
            txt_mk.PasswordChar = '*';
            txt_mk.Size = new Size(456, 27);
            txt_mk.TabIndex = 8;
            // 
            // txt_tdn
            // 
            txt_tdn.Location = new Point(152, 46);
            txt_tdn.Name = "txt_tdn";
            txt_tdn.Size = new Size(456, 27);
            txt_tdn.TabIndex = 7;
            // 
            // btn_dong
            // 
            btn_dong.Location = new Point(381, 197);
            btn_dong.Name = "btn_dong";
            btn_dong.Size = new Size(94, 29);
            btn_dong.TabIndex = 6;
            btn_dong.Text = "Đóng";
            btn_dong.UseVisualStyleBackColor = true;
            btn_dong.Click += btn_dong_Click;
            // 
            // bt_nhaplai
            // 
            bt_nhaplai.Location = new Point(181, 197);
            bt_nhaplai.Name = "bt_nhaplai";
            bt_nhaplai.Size = new Size(94, 29);
            bt_nhaplai.TabIndex = 5;
            bt_nhaplai.Text = "Nhập Lại";
            bt_nhaplai.UseVisualStyleBackColor = true;
            bt_nhaplai.Click += bt_nhaplai_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(459, 144);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 4;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(263, 144);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 3;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(101, 144);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 2;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 92);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 1;
            label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 49);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên Đăng Nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 30);
            label1.Name = "label1";
            label1.Size = new Size(426, 38);
            label1.TabIndex = 3;
            label1.Text = "Quản lý tài khoản Giáo viên";
            // 
            // Giaovien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 355);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Giaovien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giaovien";
            Load += Giaovien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txt_mk;
        private TextBox txt_tdn;
        private Button btn_dong;
        private Button bt_nhaplai;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}