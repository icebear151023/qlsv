using Microsoft.VisualBasic.Logging;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV_winform
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            trang_chu tc = new trang_chu();
            tc.Show();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == txt_repass.Text)
            {
                string connectionString = @"Data Source=ICEBEAR\SQLEXPRESS;Initial Catalog=qlsv;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM admin WHERE tk = @tk";
                    using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection))
                    {
                        checkUserCommand.Parameters.AddWithValue("@tk", txt_username.Text.Trim());
                        int userExists = (int)checkUserCommand.ExecuteScalar();

                        if (userExists > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                  
                    string insertQuery = "INSERT INTO admin (tk, mk) VALUES (@tk, @mk)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@tk", txt_username.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@mk", txt_pass.Text.Trim());

                        try
                        {
                            int result = insertCommand.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Dangnhap login = new Dangnhap();
                                login.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Đăng ký không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
        
    

