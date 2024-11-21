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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection();
        public void ketnoi()
        {
            string ketnoi = @"Data Source=ICEBEAR\SQLEXPRESS;Initial Catalog=qlsv;Integrated Security=True";
            sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();
        }
        private void LoadData()
        {
            try
            {
                string sql = "SELECT tk AS [Tên Tài Khoản], mk AS [Mật Khẩu] FROM [user]";
                DataSet ds = new DataSet();
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
                sqlda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon != null && sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            ketnoi();
            LoadData();
        }
        private void reset()
        {
            txt_tdn.Clear();
            txt_mk.Clear();
            txt_tdn.Focus();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();

                string tentk = txt_tdn.Text;
                string mk = txt_mk.Text;

                if (string.IsNullOrEmpty(tentk) || string.IsNullOrEmpty(mk))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                string sqlInsert = "INSERT INTO [user] (tk, mk) VALUES (@tentk, @mk)";
                SqlCommand cmd = new SqlCommand(sqlInsert, sqlcon);
                cmd.Parameters.AddWithValue("@tentk", tentk);
                cmd.Parameters.AddWithValue("@mk", mk);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                reset();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi thêm tài khoản: Do tài khoản này đã tồn tại" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }

        }

        private void bt_nhaplai_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txt_tdn.Text = row.Cells["Tên Tài Khoản"].Value.ToString();
                    txt_mk.Text = row.Cells["Mật Khẩu"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();


                string tentk = txt_tdn.Text;
                string mk = txt_mk.Text;

                if (string.IsNullOrEmpty(tentk) || string.IsNullOrEmpty(mk))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và mật khẩu để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                string sqlUpdate = "UPDATE [user] SET mk = @mk WHERE tk = @tentk";
                SqlCommand cmd = new SqlCommand(sqlUpdate, sqlcon);
                cmd.Parameters.AddWithValue("@tentk", tentk);
                cmd.Parameters.AddWithValue("@mk", mk);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi sửa tài khoản: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();


                string tentk = txt_tdn.Text;

                if (string.IsNullOrEmpty(tentk))
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }


                string sqlDelete = "DELETE FROM [user] WHERE tk = @tentk";
                SqlCommand cmd = new SqlCommand(sqlDelete, sqlcon);
                cmd.Parameters.AddWithValue("@tentk", tentk);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    reset();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi xóa tài khoản: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
