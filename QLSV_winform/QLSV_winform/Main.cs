using btl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_winform
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dangnhap dn = new Dangnhap();
            dn.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lb_ten.Left <= this.Width)
            {
                lb_ten.Left = lb_ten.Left + 10;
            }
            else lb_ten.Left = -lb_ten.Width;
        }

        private void lb_ten_Click(object sender, EventArgs e)
        {

        }

        private void Ts_Btn_dangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Bạn đã đăng xuất thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trang_chu f1 = new trang_chu();
                f1.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void Ts_Btn_admin_Click(object sender, EventArgs e)
        {

            Admin ad = new Admin();
            ad.Show();
        }

        private void Ts_truongkhoa_Click(object sender, EventArgs e)
        {

            Truongkhoa tk = new Truongkhoa();
            tk.Show();
        }

        private void ts_gv_Click(object sender, EventArgs e)
        {

            Giaovien gv = new Giaovien();
            gv.Show();
        }

        private void Ts_Btn_user_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
            //trang_chu trang_Chu = new trang_chu();
            //trang_Chu.Show();
        }

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
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
            tt += "Designer by: Nhóm 7 \n";
            tt += "Email: nvvquang@gmail.com \n tqhuy@gmail.com \n bvhoa@gmail.com \n\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "Liên hệ\n";
            tt += "Email: nvvquang@gmail.com \n tqhuy@gmail.com \n bvhoa@gmail.com \n\n";
            MessageBox.Show((tt), "Liên hệ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Ts_Btn_dangnhap_Click(object sender, EventArgs e)
        {
            this.Close();
            Dangnhap dn = new Dangnhap();
            dn.Show();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\WindowsApps\\Microsoft.Paint_11.2408.30.0_x64__8wekyb3d8bbwe\\PaintApp\\mspaint.exe");
        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\cmd.exe");
        }







        private void Ts_Btn_khoa_Click(object sender, EventArgs e)
        {
            Ts_Btn_dangnhap.Visible = true;
            Ts_Btn_admin.Visible = false;
            Ts_Btn_user.Visible = false;
            Ts_Btn_dangxuat.Visible = false;
            Ts_Btn_khoa.Visible = false;

            Ts_Btn_timkiem.Enabled = false;
            Ts_Btn_quanly.Enabled = false;
            Ts_capnhatdiem.Visible = false;
            Ts_Btn_hienthi.Enabled = false;
            Ts_Btn_tienich.Enabled = false;
            ts_gv.Visible = false;
            Ts_truongkhoa.Visible = false;
            Ts_Btn_thongtin.Enabled = false;
        }

        private void npToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\WindowsApps\\Microsoft.WindowsNotepad_11.2409.9.0_x64__8wekyb3d8bbwe\\Notepad\\Notepad.exe");
        }

        private void maytinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE");
        }



        private void mặcĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void ts100_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.45;
        }

        private void ts50_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
        }

        private void Ts_Btn_tt_khoa_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("khoa", "View");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_ql_khoa_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("khoa", "edit");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_ql_giaovien_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("giaovien", "edit");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_tt_giaovien_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("giaovien", "View");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_tt_lop_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("lop", "View");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_tt_sinhvien_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("sinhvien", "View");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_tt_monhoc_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("monhoc", "View");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_tt_chinhsach_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("chinhsach", "View");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_ql_lop_Click(object sender, EventArgs e)
        {

            thongtin thongTinForm = new thongtin("lop", "edit");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_ql_sinhvien_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("sinhvien", "edit");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_ql_monhoc_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("monhoc", "edit");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_ql_chinhsach_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("chinhsach", "edit");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_tk_khoa_Click(object sender, EventArgs e)
        {
            timkiem thongTinForm = new timkiem("khoa");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_tk_giaovien_Click(object sender, EventArgs e)
        {
            timkiem thongTinForm = new timkiem("giaovien");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_tk_lop_Click(object sender, EventArgs e)
        {
            timkiem thongTinForm = new timkiem("lop");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_tk_sinhvien_Click(object sender, EventArgs e)
        {
            timkiem thongTinForm = new timkiem("sinhvien");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_tk_monhoc_Click(object sender, EventArgs e)
        {
            timkiem thongTinForm = new timkiem("monhoc");

            thongTinForm.ShowDialog();
        }

        private void Ts_Btn_tk_chinhsach_Click(object sender, EventArgs e)
        {
            timkiem thongTinForm = new timkiem("chinhsach");

            thongTinForm.ShowDialog();
        }
    }
}
