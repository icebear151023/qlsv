namespace btl
{
    partial class timkiem
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            bt_dong = new Button();
            bt_loadlai = new Button();
            btntimkiem = new Button();
            cb1 = new ComboBox();
            txt1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 44);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "ladel";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_dong);
            groupBox1.Controls.Add(bt_loadlai);
            groupBox1.Controls.Add(btntimkiem);
            groupBox1.Controls.Add(cb1);
            groupBox1.Controls.Add(txt1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(27, 94);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(351, 378);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // bt_dong
            // 
            bt_dong.Location = new Point(258, 310);
            bt_dong.Margin = new Padding(3, 4, 3, 4);
            bt_dong.Name = "bt_dong";
            bt_dong.Size = new Size(75, 29);
            bt_dong.TabIndex = 3;
            bt_dong.Text = "Đóng";
            bt_dong.UseVisualStyleBackColor = true;
            // 
            // bt_loadlai
            // 
            bt_loadlai.Location = new Point(122, 310);
            bt_loadlai.Margin = new Padding(3, 4, 3, 4);
            bt_loadlai.Name = "bt_loadlai";
            bt_loadlai.Size = new Size(75, 29);
            bt_loadlai.TabIndex = 2;
            bt_loadlai.Text = "Load Lại";
            bt_loadlai.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(6, 310);
            btntimkiem.Margin = new Padding(3, 4, 3, 4);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(75, 29);
            btntimkiem.TabIndex = 2;
            btntimkiem.Text = "Tìm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Location = new Point(101, 215);
            cb1.Margin = new Padding(3, 4, 3, 4);
            cb1.Name = "cb1";
            cb1.Size = new Size(121, 28);
            cb1.TabIndex = 1;
            cb1.SelectedIndexChanged += cb1_SelectedIndexChanged;
            // 
            // txt1
            // 
            txt1.Location = new Point(97, 119);
            txt1.Margin = new Padding(3, 4, 3, 4);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 27);
            txt1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 218);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 0;
            label3.Text = "Tìm Theo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 119);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Từ Khóa";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(427, 104);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(601, 358);
            dataGridView1.TabIndex = 0;
            // 
            // timkiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 498);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "timkiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "timkiem";
            Load += timkiem_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button bt_dong;
        private System.Windows.Forms.Button bt_loadlai;
        private System.Windows.Forms.Button btntimkiem;
        private DataGridView dataGridView1;
    }
}