namespace btl
{
    partial class thongtin
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
            txt4 = new TextBox();
            txt3 = new TextBox();
            rd_nu = new RadioButton();
            rd_nam = new RadioButton();
            dt_ns = new DateTimePicker();
            btnsua = new Button();
            btnthem = new Button();
            btnxoa = new Button();
            btncancel = new Button();
            btnin = new Button();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt8 = new TextBox();
            txt7 = new TextBox();
            txt6 = new TextBox();
            txt5 = new TextBox();
            txt2 = new TextBox();
            txt1 = new TextBox();
            lb_ten = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 121);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(491, 545);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt4);
            groupBox1.Controls.Add(txt3);
            groupBox1.Controls.Add(rd_nu);
            groupBox1.Controls.Add(rd_nam);
            groupBox1.Controls.Add(dt_ns);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btncancel);
            groupBox1.Controls.Add(btnin);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt8);
            groupBox1.Controls.Add(txt7);
            groupBox1.Controls.Add(txt6);
            groupBox1.Controls.Add(txt5);
            groupBox1.Controls.Add(txt2);
            groupBox1.Controls.Add(txt1);
            groupBox1.Location = new Point(550, 121);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(402, 546);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txt4
            // 
            txt4.Location = new Point(152, 225);
            txt4.Name = "txt4";
            txt4.Size = new Size(221, 27);
            txt4.TabIndex = 7;
            // 
            // txt3
            // 
            txt3.Location = new Point(152, 172);
            txt3.Name = "txt3";
            txt3.Size = new Size(221, 27);
            txt3.TabIndex = 6;
            // 
            // rd_nu
            // 
            rd_nu.AutoSize = true;
            rd_nu.Location = new Point(323, 173);
            rd_nu.Name = "rd_nu";
            rd_nu.Size = new Size(50, 24);
            rd_nu.TabIndex = 5;
            rd_nu.TabStop = true;
            rd_nu.Text = "Nữ";
            rd_nu.UseVisualStyleBackColor = true;
            // 
            // rd_nam
            // 
            rd_nam.AutoSize = true;
            rd_nam.Location = new Point(152, 173);
            rd_nam.Name = "rd_nam";
            rd_nam.Size = new Size(62, 24);
            rd_nam.TabIndex = 4;
            rd_nam.TabStop = true;
            rd_nam.Text = "Nam";
            rd_nam.UseVisualStyleBackColor = true;
            // 
            // dt_ns
            // 
            dt_ns.Format = DateTimePickerFormat.Short;
            dt_ns.Location = new Point(152, 223);
            dt_ns.Name = "dt_ns";
            dt_ns.Size = new Size(221, 27);
            dt_ns.TabIndex = 3;
            dt_ns.Value = new DateTime(2024, 11, 21, 23, 48, 20, 0);
            // 
            // btnsua
            // 
            btnsua.Location = new Point(168, 500);
            btnsua.Margin = new Padding(3, 4, 3, 4);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(75, 41);
            btnsua.TabIndex = 2;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(18, 500);
            btnthem.Margin = new Padding(3, 4, 3, 4);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(75, 41);
            btnthem.TabIndex = 2;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(318, 500);
            btnxoa.Margin = new Padding(3, 4, 3, 4);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(75, 41);
            btnxoa.TabIndex = 2;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(243, 500);
            btncancel.Margin = new Padding(3, 4, 3, 4);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(75, 41);
            btncancel.TabIndex = 2;
            btncancel.Text = "Đóng";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnin
            // 
            btnin.Location = new Point(93, 500);
            btnin.Margin = new Padding(3, 4, 3, 4);
            btnin.Name = "btnin";
            btnin.Size = new Size(75, 41);
            btnin.TabIndex = 2;
            btnin.Text = "In";
            btnin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 462);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 1;
            label8.Text = "Tên lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 345);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 1;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 286);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 1;
            label5.Text = "Số điện thoại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 404);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 1;
            label7.Text = "Tên chính sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 175);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 1;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 228);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 1;
            label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 116);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sinh viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 58);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã sinh viên";
            // 
            // txt8
            // 
            txt8.Location = new Point(152, 451);
            txt8.Margin = new Padding(3, 4, 3, 4);
            txt8.Name = "txt8";
            txt8.Size = new Size(221, 27);
            txt8.TabIndex = 0;
            // 
            // txt7
            // 
            txt7.Location = new Point(152, 396);
            txt7.Margin = new Padding(3, 4, 3, 4);
            txt7.Name = "txt7";
            txt7.Size = new Size(221, 27);
            txt7.TabIndex = 0;
            // 
            // txt6
            // 
            txt6.Location = new Point(152, 338);
            txt6.Margin = new Padding(3, 4, 3, 4);
            txt6.Name = "txt6";
            txt6.Size = new Size(221, 27);
            txt6.TabIndex = 0;
            // 
            // txt5
            // 
            txt5.Location = new Point(152, 282);
            txt5.Margin = new Padding(3, 4, 3, 4);
            txt5.Name = "txt5";
            txt5.Size = new Size(221, 27);
            txt5.TabIndex = 0;
            // 
            // txt2
            // 
            txt2.Location = new Point(152, 109);
            txt2.Margin = new Padding(3, 4, 3, 4);
            txt2.Name = "txt2";
            txt2.Size = new Size(221, 27);
            txt2.TabIndex = 0;
            // 
            // txt1
            // 
            txt1.Location = new Point(152, 54);
            txt1.Margin = new Padding(3, 4, 3, 4);
            txt1.Name = "txt1";
            txt1.Size = new Size(221, 27);
            txt1.TabIndex = 0;
            // 
            // lb_ten
            // 
            lb_ten.AutoSize = true;
            lb_ten.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_ten.Location = new Point(464, 38);
            lb_ten.Name = "lb_ten";
            lb_ten.Size = new Size(117, 46);
            lb_ten.TabIndex = 2;
            lb_ten.Text = "label9";
            // 
            // thongtin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 710);
            Controls.Add(lb_ten);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "thongtin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "thongtin";
            Load += thongtin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private DateTimePicker dt_ns;
        private RadioButton rd_nu;
        private RadioButton rd_nam;
        private Label lb_ten;
        private TextBox txt4;
        private TextBox txt3;
    }
}