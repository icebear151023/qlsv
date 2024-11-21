namespace QLSV_winform
{
    public partial class trang_chu : Form
    {
       
        public trang_chu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TRƯỜNG ĐẠI HỌC KINH TẾ KỸ THUẬT CÔNG NGHIỆP");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Dangnhap lg = new Dangnhap();
            lg.Show();
            this.Hide();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            Dangky dk = new Dangky();
            dk.Show();
            this.Hide();
        }

        private void btn_tt_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "Phần mềm: QUẢN LÝ SINH VIÊN\n";
            tt += "\n";
            tt += "Version: 1.1 \n";
            tt += "\n";
            tt += "Học phần thực tập:\n\n";
            tt += "Lập trình hướng cơ sở dữ liệu \n";
            tt += "\n\n";
            tt += "Copy right @ năm 2024 \n";
            tt += "Designer by: Nguyễn Viết Vinh Quang \n";
            tt += "Email: quagxaolin@gmail.com \n\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (label2.Left <= this.Width)
            {
                label2.Left = label2.Left + 10;
            }
            else label2.Left = -label2.Width;
        }
    }
}
