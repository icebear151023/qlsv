using QLSV_winform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl
{
    public partial class thongtin : Form
    {
        private string  mode;
        private string tableName;
        
        public thongtin(string tableName, string mode)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.mode = mode;
        }

        private void thongtin_Load(object sender, EventArgs e)
        {

            btnsua.Visible = false;
            btnthem.Visible = false;
            btnxoa.Visible = false;

            LoadData(tableName);
           
            switch (tableName)
            {
                case "khoa":
                    lb_ten.Text = "Khoa";
                    label1.Text = "Mã Khoa";
                    label2.Text = "Tên Khoa";
                    label3.Visible =false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    rd_nam.Visible = false;
                    rd_nu.Visible = false;  
                    dt_ns.Visible = false;
                    txt3.Visible = false;
                    txt4.Visible = false;
                    txt5.Visible = false;
                    txt6.Visible = false;
                    txt7.Visible = false;
                    txt8.Visible = false;
                    
                  
                    break;

                case "giaovien":
                    lb_ten.Text = "Giáo Viên";
                    label1.Text = "Mã Giáo Viên";
                    label2.Text = "Tên Giáo Viên";
                    label3.Text = "Giới Tính";
                    label4.Text = "Ngày Sinh";
                    label5.Text = "Số Điện Thoại";
                    label6.Text = "Địa Chỉ";
                    label7.Visible = false;
                    label8.Visible = false;
                    txt7.Visible = false;
                    txt8.Visible = false;
                    txt3.Visible = false;
                    txt4.Visible = false;
                    break;

                case "sinhvien":
                    lb_ten.Text = "Sinh Viên";
                    label1.Text = "Mã Sinh Viên";
                    label2.Text = "Tên Sinh Viên";
                    label3.Text = "Giới Tính";
                    label4.Text = "Ngày Sinh";
                    label5.Text = "Số Điện Thoại";
                    label6.Text = "Địa Chỉ";
                    label7.Text = "Mã Chính Sách";
                    label8.Text = "Mã Lớp";
                    txt3.Visible = false;
                    txt4.Visible = false;

                    break;

                case "chinhsach":
                    lb_ten.Text = "Chính Sách";
                    label1.Text = "Mã Chính Sách";
                    label2.Text = "Tên Chính Sách";
                    label3.Text = "Chế Độ";
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    rd_nam.Visible = false;
                    rd_nu.Visible = false;
                    dt_ns.Visible = false;
                    txt5.Visible = false;
                    txt6.Visible = false;
                    txt7.Visible = false;
                    txt8.Visible = false;
                    txt4.Visible = false;
                    break;

                case "monhoc":
                    lb_ten.Text = "Môn Học";
                    label1.Text = "Mã Môn Học";
                    label2.Text = "Tên Môn Học";
                    label3.Text = "Số Tiết";
                    label4.Text = "Mã Giáo Viên";
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    rd_nam.Visible = false;
                    rd_nu.Visible = false;
                    dt_ns.Visible = false;

                    txt5.Visible = false;
                    txt6.Visible = false;
                    txt7.Visible = false;
                    txt8.Visible = false;

                    break;

                case "lop":
                    lb_ten.Text = "Lớp";
                    label1.Text = "Mã Lớp";
                    label2.Text = "Tên Lớp";
                    label3.Text = "Mã Khoa";
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    
                    txt4.Visible = false;
                    rd_nam.Visible = false;
                    rd_nu.Visible = false;
                    dt_ns.Visible = false;
                    txt5.Visible = false;
                    txt6.Visible = false;
                    txt7.Visible = false;
                    txt8.Visible = false;
               

                    break;
                case "diem":
                    lb_ten.Text = "Điểm";
                    label1.Text = "ID";
                    label2.Text = "Mã Sinh Viên";
                    label3.Text = "Mã Môn Học";
                    label4.Text = "Điểm";
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;

                    txt4.Visible = false;
                    rd_nam.Visible = false;
                    rd_nu.Visible = false;
                    dt_ns.Visible = false;
                    txt5.Visible = false;
                    txt6.Visible = false;
                    txt7.Visible = false;
                    txt8.Visible = false;
                    break;
                default:
                    label1.Text = "Mã";
                    label2.Text = "Tên";
                    break;
            }
            if (mode == "edit")
            {
                btnsua.Visible = true;
                btnthem.Visible = true;
                btnxoa.Visible = true;
                btnin.Visible = false;
                btncancel.Visible = false;  
            }
        }
        public void LoadData(string tableName)
        {
            string query = $"SELECT * FROM {tableName}";
            DataTable data = GetDataFromDatabase(query); 

            dataGridView1.DataSource = data; 
        }
        private DataTable GetDataFromDatabase(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = database.OpenConnection())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dataTable); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
            return dataTable;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO {tableName} VALUES (@Ma, @Ten)"; 
            try
            {
                using (SqlConnection conn = database.OpenConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        string gt = null;
                        if (rd_nu.Checked = true)
                        {
                            gt = "Nữ";
                        }
                        else
                        if (rd_nam.Checked = true)
                        {
                            gt = "Nam";
                        }

                        DateTime ngaysinh = dt_ns.Value;
                        switch (tableName)
                        {
                            case "khoa":
                                query = "INSERT INTO khoa (MaKhoa, TenKhoa) VALUES (@MaKhoa, @TenKhoa)";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaKhoa", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenKhoa", txt2.Text);
                                break;

                            case "giaovien":
                                query = "INSERT INTO giaovien (MaGV, TenGV, GioiTinh, NgaySinh, SDT, DiaChi) VALUES (@MaGV, @TenGV, @GioiTinh, @NgaySinh, @SDT, @DiaChi)";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaGV", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenGV", txt2.Text);
                                cmd.Parameters.AddWithValue("@GioiTinh", gt);
                                cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                                cmd.Parameters.AddWithValue("@SDT", txt5.Text);
                                cmd.Parameters.AddWithValue("@DiaChi", txt6.Text);
                                break;

                            case "sinhvien"://cần
                                query = "INSERT INTO sinhvien (MaSV, TenSV, GioiTinh, NgaySinh, SDT, DiaChi, MaCS, MaLop) VALUES (@MaSV, @TenSV, @GioiTinh, @NgaySinh, @SDT, @DiaChi, @MaChinhSach, @MaLop)";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaSV", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenSV", txt2.Text);
                                cmd.Parameters.AddWithValue("@GioiTinh", gt);
                                cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                                cmd.Parameters.AddWithValue("@SDT", txt5.Text);
                                cmd.Parameters.AddWithValue("@DiaChi", txt6.Text);
                                cmd.Parameters.AddWithValue("@MaChinhSach", txt7.Text);
                                cmd.Parameters.AddWithValue("@MaLop", txt8.Text);
                                break;

                            case "lop"://cần
                                query = "INSERT INTO lop (MaLop, TenLop, MaKhoa) VALUES (@MaLop, @TenLop, @MaKhoa)";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaLop", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenLop", txt2.Text);
                                cmd.Parameters.AddWithValue("@MaKhoa", txt3.Text);
                                break;

                            case "monhoc"://cần
                                query = "INSERT INTO monhoc (MaMH, TenMH, SoTiet, MaGV) VALUES (@MaMH, @TenMH, @SoTiet, @MaGV)";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaMH", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenMH", txt2.Text);
                                cmd.Parameters.AddWithValue("@SoTiet", int.Parse(txt3.Text));
                                cmd.Parameters.AddWithValue("@MaGV", txt4.Text);
                                break;

                            case "chinhsach":
                                query = "INSERT INTO chinhsach (MaCS, TenCS, CheDo) VALUES (@MaCS, @TenCS, @CheDo)";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaCS", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenCS", txt2.Text);
                                cmd.Parameters.AddWithValue("@CheDo", txt3.Text);
                               

                                break;
                            default:
                                MessageBox.Show("Bảng không hợp lệ.");
                                return;
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                        LoadData(tableName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: Mã đã tồn tại" );
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string gt = null;
            if (rd_nu.Checked = true)
            {
                gt = "Nữ";
            }
            else
            if (rd_nam.Checked = true)
            {
                gt = "Nam";
            }

            DateTime ngaysinh = dt_ns.Value;
            string query = "";
            try
            {
                using (SqlConnection conn = database.OpenConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        switch (tableName)
                        {
                            case "khoa":
                                query = "UPDATE khoa SET TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoa";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaKhoa", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenKhoa", txt2.Text);
                                break;

                            case "giaovien":
                                query = "UPDATE giaovien SET TenGV = @TenGV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SDT = @SDT, DiaChi = @DiaChi WHERE MaGV = @MaGV";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaGV", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenGV", txt2.Text);
                                cmd.Parameters.AddWithValue("@GioiTinh", gt);
                                cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                                cmd.Parameters.AddWithValue("@SDT", txt5.Text);
                                cmd.Parameters.AddWithValue("@DiaChi", txt6.Text);
                                break;

                            case "sinhvien":
                                query = "UPDATE sinhvien SET TenSV = @TenSV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SDT = @SDT, DiaChi = @DiaChi, MaCS = @MaChinhSach, MaLop = @MaLop WHERE MaSV = @MaSV";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaSV", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenSV", txt2.Text);
                                cmd.Parameters.AddWithValue("@GioiTinh", gt);
                                cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                                cmd.Parameters.AddWithValue("@SDT", txt5.Text);
                                cmd.Parameters.AddWithValue("@DiaChi", txt6.Text);
                                cmd.Parameters.AddWithValue("@MaChinhSach", txt7.Text);
                                cmd.Parameters.AddWithValue("@MaLop", txt8.Text);
                                break;

                            case "lop":
                                query = "UPDATE lop SET TenLop = @TenLop, MaKhoa = @MaKhoa WHERE MaLop = @MaLop";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaLop", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenLop", txt2.Text);
                                cmd.Parameters.AddWithValue("@MaKhoa", txt3.Text);
                                break;

                            case "monhoc":
                                query = "UPDATE monhoc SET TenMH = @TenMH, SoTiet = @SoTiet, MaGV = @MaGV WHERE MaMH = @MaMH";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaMH", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenMH", txt2.Text);
                                cmd.Parameters.AddWithValue("@SoTiet", int.Parse(txt3.Text)); // Giả sử SoTiet là số nguyên
                                cmd.Parameters.AddWithValue("@MaGV", txt4.Text);
                                break;

                            case "chinhsach":
                                query = "UPDATE chinhsach SET TenCS = @TenCS, CheDo = @CheDo WHERE MaCS = @MaCS";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaCS", txt1.Text);
                                cmd.Parameters.AddWithValue("@TenCS", txt2.Text);
                                cmd.Parameters.AddWithValue("@CheDo", txt3.Text);
                                break;

                            default:
                                MessageBox.Show("Bảng không hợp lệ.");
                                return;
                        }

                        // Thực thi câu lệnh UPDATE
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!");

                        // Tải lại dữ liệu sau khi cập nhật
                        LoadData(tableName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txt1.Text;

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng nhập mã cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            string query = "";
            try
            {
                using (SqlConnection conn = database.OpenConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        switch (tableName)
                        {
                            case "khoa":
                                query = "DELETE FROM khoa WHERE makhoa = @MaKhoa";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaKhoa", txt1.Text);
                                break;

                            case "giaovien":
                                query = "DELETE FROM giaovien WHERE magv = @MaGV";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaGV", txt1.Text);
                                break;

                            case "sinhvien":
                                query = "DELETE FROM sinhvien WHERE masv = @MaSV";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaSV", txt1.Text);
                                break;

                            case "lop":
                                query = "DELETE FROM lop WHERE malop = @MaLop";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaLop", txt1.Text);
                                break;

                            case "monhoc":
                                query = "DELETE FROM monhoc WHERE manh = @MaMH";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaMH", txt1.Text);
                                break;

                            case "chinhsach":
                                query = "DELETE FROM chinhsach WHERE macs = @MaCS";
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@MaCS", txt1.Text);
                                break;

                            default:
                                MessageBox.Show("Bảng không hợp lệ.");
                                return;
                        }

                        // Thực thi câu lệnh DELETE
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");

                        // Tải lại dữ liệu sau khi xóa
                        LoadData(tableName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Cập nhật các TextBox dựa trên bảng hiện tại (tableName)
                switch (tableName)
                {
                    case "khoa":
                        // Cập nhật các TextBox với dữ liệu từ bảng khoa
                        txt1.Text = row.Cells["makhoa"].Value.ToString();
                        txt2.Text = row.Cells["tenkhoa"].Value.ToString();
                        // Ẩn các TextBox không sử dụng
                        txt3.Visible = false;
                        txt4.Visible = false;
                        txt5.Visible = false;
                        txt6.Visible = false;
                        txt7.Visible = false;
                        txt8.Visible = false;
                        break;

                    case "giaovien":
                        // Cập nhật các TextBox với dữ liệu từ bảng giaovien
                        txt1.Text = row.Cells["MaGV"].Value.ToString();
                        txt2.Text = row.Cells["TenGV"].Value.ToString();
                        dt_ns.Text = row.Cells["Ngaysinh"].Value.ToString();
                        string gt = row.Cells["Gioitinh"].Value.ToString();
                        if (gt == "Nam")
                        {
                            rd_nam.Checked = true;
                            rd_nu.Checked = false;
                        }
                        if (gt == "Nữ")
                        {
                            rd_nam.Checked = false;
                            rd_nu.Checked = true;
                        }
                        txt5.Text = row.Cells["SDT"].Value.ToString();
                        txt6.Text = row.Cells["DiaChi"].Value.ToString();
                        // Ẩn các TextBox không sử dụng
                        txt7.Visible = false;
                        txt8.Visible = false;
                        break;

                    case "sinhvien":
                        // Cập nhật các TextBox với dữ liệu từ bảng sinhvien
                        txt1.Text = row.Cells["MaSV"].Value.ToString();
                        txt2.Text = row.Cells["TenSV"].Value.ToString();
                        dt_ns.Text = row.Cells["Ngaysinh"].Value.ToString();
                        string gtsv = row.Cells["Gioitinh"].Value.ToString();
                        if (gtsv == "Nam")
                        {
                            rd_nam.Checked = true;
                            rd_nu.Checked = false;
                        }
                        if (gtsv == "Nữ")
                        {
                            rd_nam.Checked = false;
                            rd_nu.Checked = true;
                        }
                        txt5.Text = row.Cells["SDT"].Value.ToString();
                        txt6.Text = row.Cells["DiaChi"].Value.ToString();
                        txt7.Text = row.Cells["MaCS"].Value.ToString();
                        txt8.Text = row.Cells["MaLop"].Value.ToString();
                        break;

                    case "chinhsach":
                        // Cập nhật các TextBox với dữ liệu từ bảng chinhsach
                        txt1.Text = row.Cells["MaCS"].Value.ToString();
                        txt2.Text = row.Cells["TenCS"].Value.ToString();
                        txt3.Text = row.Cells["CheDo"].Value.ToString();
                        // Ẩn các TextBox không sử dụng
                        txt4.Visible = false;
                        txt5.Visible = false;
                        txt6.Visible = false;
                        txt7.Visible = false;
                        txt8.Visible = false;
                        break;

                    case "monhoc":
                        // Cập nhật các TextBox với dữ liệu từ bảng monhoc
                        txt1.Text = row.Cells["MaMH"].Value.ToString();
                        txt2.Text = row.Cells["TenMH"].Value.ToString();
                        txt3.Text = row.Cells["SoTiet"].Value.ToString();
                        txt4.Text = row.Cells["MaGV"].Value.ToString();
                        // Ẩn các TextBox không sử dụng
                        txt5.Visible = false;
                        txt6.Visible = false;
                        txt7.Visible = false;
                        txt8.Visible = false;
                        break;

                    case "lop":
                        // Cập nhật các TextBox với dữ liệu từ bảng lop
                        txt1.Text = row.Cells["MaLop"].Value.ToString();
                        txt2.Text = row.Cells["TenLop"].Value.ToString();
                        txt3.Text = row.Cells["MaKhoa"].Value.ToString();
                        // Ẩn các TextBox không sử dụng
                        txt4.Visible = false;
                        txt5.Visible = false;
                        txt6.Visible = false;
                        txt7.Visible = false;
                        txt8.Visible = false;
                        break;

                    default:
                        MessageBox.Show("Bảng không hợp lệ.");
                        break;
                }
            }
        }
    }
}
