using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV_winform
{
    public partial class Dangnhap : Form
    {
        private int loginAttempts = 0;
        private const int MaxAttempts = 3;
        SqlConnection sqlcon;

        public Dangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            trang_chu tc = new trang_chu();
            tc.Show();
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string username = txt_tk.Text;
            string password = txt_mk.Text;

            if (username == "" || password == "")

            {
                MessageBox.Show("Chưa nhập tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tk.Focus();

            }

            txt_tk.Focus();
            string connectionString = @"Data Source=ICEBEAR\SQLEXPRESS;Initial Catalog=qlsv;Integrated Security=True";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                if (IsValidAccount(connection, "admin", username, password))
                {
                    this.Close();
                    Main main = new Main();
                    main.Show();
                    main.Ts_capnhatdiem.Visible = false;

                    MessageBox.Show("Đăng nhập thành công bằng tài khoản Admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginAttempts = 0;
                    return;



                }


                if (IsValidAccount(connection, "[user]", username, password))
                {
                    this.Close();
                    Main main = new Main();
                    main.Show();
                    main.Ts_Btn_dangnhap.Visible = false;
                    main.Ts_Btn_admin.Visible = false;
                    main.Ts_truongkhoa.Visible = false;
                    main.ts_gv.Visible = false;
                    main.Ts_Btn_user.Visible = false;
                    main.Ts_Btn_quanly.Visible = false;
                    main.Ts_capnhatdiem.Visible = false;
                    main.toolStripSeparator1.Visible = false;
                    MessageBox.Show("Đăng nhập thành công bằng tài khoản User", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginAttempts = 0;
                    return;

                }


                if (IsValidAccount(connection, "[gv]", username, password))
                {
                    this.Close();
                    Main main = new Main();
                    main.Show();
                    main.Ts_Btn_dangnhap.Visible = false;
                    main.Ts_Btn_admin.Visible = false;
                    main.Ts_truongkhoa.Visible = false;
                    main.ts_gv.Visible = false;
                    main.Ts_Btn_user.Visible = false;
                    main.Ts_Btn_quanly.Visible = false;
                    main.toolStripSeparator1.Visible = false;
                    MessageBox.Show("Đăng nhập thành công bằng tài khoản Giáo Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginAttempts = 0;
                    return;

                }
                if (IsValidAccount(connection, "[truongkhoa]", username, password))
                {
                    this.Close();
                    Main main = new Main();
                    main.Show();
                    main.Ts_Btn_dangnhap.Visible = false;
                    main.Ts_Btn_admin.Visible = false;
                    main.Ts_truongkhoa.Visible = false;
                    main.ts_gv.Visible = false;
                    main.Ts_Btn_user.Visible = false;
                    main.Ts_capnhatdiem.Visible = false;
                    main.toolStripSeparator1.Visible = false;
                    MessageBox.Show("Đăng nhập thành công bằng tài khoản Trưởng Khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginAttempts = 0;
                    return;

                }





                loginAttempts++;
                MessageBox.Show($"Bạn đã nhập sai {loginAttempts} lần.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);


                if (loginAttempts >= 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần. Vui lòng đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    trang_chu tc = new trang_chu();
                    tc.Show();

                }
            }



        }

        private bool IsValidAccount(SqlConnection connection, string tableName, string username, string password)
        {
            string query = $"SELECT COUNT(*) FROM {tableName} WHERE tk = @username AND mk = @password";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int result = (int)command.ExecuteScalar();
                return result > 0;
            }
        }

        private void btn_ok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ok.PerformClick();
                e.Handled = true;
            }
        }

        private void txt_mk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ok.PerformClick();
                e.Handled = true;
            }
        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_tk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ok.PerformClick();
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangky dk = new Dangky();
            dk.Show();
            this.Close();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
