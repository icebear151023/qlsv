namespace QLSV_winform
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            Ts_Btn_hethong = new ToolStripMenuItem();
            Ts_Btn_admin = new ToolStripMenuItem();
            Ts_truongkhoa = new ToolStripMenuItem();
            ts_gv = new ToolStripMenuItem();
            Ts_Btn_user = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            Ts_Btn_khoa = new ToolStripMenuItem();
            Ts_Btn_doimatkhau = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripSeparator();
            Ts_Btn_dangnhap = new ToolStripMenuItem();
            Ts_Btn_dangxuat = new ToolStripMenuItem();
            Ts_Btn_thongtin = new ToolStripMenuItem();
            Ts_Btn_tt_khoa = new ToolStripMenuItem();
            Ts_Btn_tt_giaovien = new ToolStripMenuItem();
            Ts_Btn_tt_lop = new ToolStripMenuItem();
            Ts_Btn_tt_sinhvien = new ToolStripMenuItem();
            Ts_Btn_tt_monhoc = new ToolStripMenuItem();
            Ts_Btn_tt_chinhsach = new ToolStripMenuItem();
            Ts_Btn_tt_diem = new ToolStripMenuItem();
            Ts_Btn_timkiem = new ToolStripMenuItem();
            Ts_Btn_tk_khoa = new ToolStripMenuItem();
            Ts_Btn_tk_giaovien = new ToolStripMenuItem();
            Ts_Btn_tk_lop = new ToolStripMenuItem();
            Ts_Btn_tk_sinhvien = new ToolStripMenuItem();
            Ts_Btn_tk_monhoc = new ToolStripMenuItem();
            Ts_Btn_tk_chinhsach = new ToolStripMenuItem();
            Ts_capnhatdiem = new ToolStripMenuItem();
            Ts_Btn_quanly = new ToolStripMenuItem();
            Ts_Btn_ql_khoa = new ToolStripMenuItem();
            Ts_Btn_ql_giaovien = new ToolStripMenuItem();
            Ts_Btn_ql_lop = new ToolStripMenuItem();
            Ts_Btn_ql_sinhvien = new ToolStripMenuItem();
            Ts_Btn_ql_monhoc = new ToolStripMenuItem();
            Ts_Btn_ql_chinhsach = new ToolStripMenuItem();
            Ts_Btn_ql_diem = new ToolStripMenuItem();
            Ts_Btn_hienthi = new ToolStripMenuItem();
            kiểuXemToolStripMenuItem = new ToolStripMenuItem();
            trongSuốtToolStripMenuItem = new ToolStripMenuItem();
            ts100 = new ToolStripMenuItem();
            ts50 = new ToolStripMenuItem();
            mặcĐịnhToolStripMenuItem = new ToolStripMenuItem();
            ngônNgữToolStripMenuItem = new ToolStripMenuItem();
            tiếngViệtToolStripMenuItem = new ToolStripMenuItem();
            tiếngAnhToolStripMenuItem = new ToolStripMenuItem();
            Ts_Btn_tienich = new ToolStripMenuItem();
            paintToolStripMenuItem = new ToolStripMenuItem();
            cmdToolStripMenuItem = new ToolStripMenuItem();
            npToolStripMenuItem = new ToolStripMenuItem();
            maytinhToolStripMenuItem = new ToolStripMenuItem();
            wordToolStripMenuItem = new ToolStripMenuItem();
            hỗTrợToolStripMenuItem = new ToolStripMenuItem();
            liênHệToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem1 = new ToolStripMenuItem();
            cậpNhậtPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            lb_time = new Label();
            lb_ten = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Ts_Btn_hethong, Ts_Btn_thongtin, Ts_Btn_timkiem, Ts_capnhatdiem, Ts_Btn_quanly, Ts_Btn_hienthi, Ts_Btn_tienich, hỗTrợToolStripMenuItem, thoatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // Ts_Btn_hethong
            // 
            Ts_Btn_hethong.DropDownItems.AddRange(new ToolStripItem[] { Ts_Btn_admin, Ts_truongkhoa, ts_gv, Ts_Btn_user, toolStripSeparator1, Ts_Btn_khoa, Ts_Btn_doimatkhau, đăngXuấtToolStripMenuItem, Ts_Btn_dangnhap, Ts_Btn_dangxuat });
            Ts_Btn_hethong.Name = "Ts_Btn_hethong";
            Ts_Btn_hethong.Size = new Size(85, 24);
            Ts_Btn_hethong.Text = "Hệ thống";
            // 
            // Ts_Btn_admin
            // 
            Ts_Btn_admin.Name = "Ts_Btn_admin";
            Ts_Btn_admin.Size = new Size(292, 26);
            Ts_Btn_admin.Text = "Quản lý tài khoản admin";
            Ts_Btn_admin.Click += Ts_Btn_admin_Click;
            // 
            // Ts_truongkhoa
            // 
            Ts_truongkhoa.Name = "Ts_truongkhoa";
            Ts_truongkhoa.Size = new Size(292, 26);
            Ts_truongkhoa.Text = "Quản lý tài khoản trưởng khoa";
            Ts_truongkhoa.Click += Ts_truongkhoa_Click;
            // 
            // ts_gv
            // 
            ts_gv.Name = "ts_gv";
            ts_gv.Size = new Size(292, 26);
            ts_gv.Text = "Quản lý tài khoản giáo viên";
            ts_gv.Click += ts_gv_Click;
            // 
            // Ts_Btn_user
            // 
            Ts_Btn_user.Name = "Ts_Btn_user";
            Ts_Btn_user.Size = new Size(292, 26);
            Ts_Btn_user.Text = "Quản lý tài khoản user";
            Ts_Btn_user.Click += Ts_Btn_user_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(289, 6);
            // 
            // Ts_Btn_khoa
            // 
            Ts_Btn_khoa.Name = "Ts_Btn_khoa";
            Ts_Btn_khoa.Size = new Size(292, 26);
            Ts_Btn_khoa.Text = "Khóa";
            Ts_Btn_khoa.Click += Ts_Btn_khoa_Click;
            // 
            // Ts_Btn_doimatkhau
            // 
            Ts_Btn_doimatkhau.Name = "Ts_Btn_doimatkhau";
            Ts_Btn_doimatkhau.Size = new Size(292, 26);
            Ts_Btn_doimatkhau.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(289, 6);
            // 
            // Ts_Btn_dangnhap
            // 
            Ts_Btn_dangnhap.Name = "Ts_Btn_dangnhap";
            Ts_Btn_dangnhap.Size = new Size(292, 26);
            Ts_Btn_dangnhap.Text = "Đăng nhập";
            Ts_Btn_dangnhap.Click += Ts_Btn_dangnhap_Click;
            // 
            // Ts_Btn_dangxuat
            // 
            Ts_Btn_dangxuat.Name = "Ts_Btn_dangxuat";
            Ts_Btn_dangxuat.Size = new Size(292, 26);
            Ts_Btn_dangxuat.Text = "Đăng xuất";
            Ts_Btn_dangxuat.Click += Ts_Btn_dangxuat_Click;
            // 
            // Ts_Btn_thongtin
            // 
            Ts_Btn_thongtin.DropDownItems.AddRange(new ToolStripItem[] { Ts_Btn_tt_khoa, Ts_Btn_tt_giaovien, Ts_Btn_tt_lop, Ts_Btn_tt_sinhvien, Ts_Btn_tt_monhoc, Ts_Btn_tt_chinhsach, Ts_Btn_tt_diem });
            Ts_Btn_thongtin.Name = "Ts_Btn_thongtin";
            Ts_Btn_thongtin.Size = new Size(86, 24);
            Ts_Btn_thongtin.Text = "Thông tin";
            // 
            // Ts_Btn_tt_khoa
            // 
            Ts_Btn_tt_khoa.Name = "Ts_Btn_tt_khoa";
            Ts_Btn_tt_khoa.Size = new Size(162, 26);
            Ts_Btn_tt_khoa.Text = "Khoa ";
            Ts_Btn_tt_khoa.Click += Ts_Btn_tt_khoa_Click;
            // 
            // Ts_Btn_tt_giaovien
            // 
            Ts_Btn_tt_giaovien.Name = "Ts_Btn_tt_giaovien";
            Ts_Btn_tt_giaovien.Size = new Size(162, 26);
            Ts_Btn_tt_giaovien.Text = "Giáo viên";
            Ts_Btn_tt_giaovien.Click += Ts_Btn_tt_giaovien_Click;
            // 
            // Ts_Btn_tt_lop
            // 
            Ts_Btn_tt_lop.Name = "Ts_Btn_tt_lop";
            Ts_Btn_tt_lop.Size = new Size(162, 26);
            Ts_Btn_tt_lop.Text = "Lớp ";
            Ts_Btn_tt_lop.Click += Ts_Btn_tt_lop_Click;
            // 
            // Ts_Btn_tt_sinhvien
            // 
            Ts_Btn_tt_sinhvien.Name = "Ts_Btn_tt_sinhvien";
            Ts_Btn_tt_sinhvien.Size = new Size(162, 26);
            Ts_Btn_tt_sinhvien.Text = "Sinh viên";
            Ts_Btn_tt_sinhvien.Click += Ts_Btn_tt_sinhvien_Click;
            // 
            // Ts_Btn_tt_monhoc
            // 
            Ts_Btn_tt_monhoc.Name = "Ts_Btn_tt_monhoc";
            Ts_Btn_tt_monhoc.Size = new Size(162, 26);
            Ts_Btn_tt_monhoc.Text = "Môn học";
            Ts_Btn_tt_monhoc.Click += Ts_Btn_tt_monhoc_Click;
            // 
            // Ts_Btn_tt_chinhsach
            // 
            Ts_Btn_tt_chinhsach.Name = "Ts_Btn_tt_chinhsach";
            Ts_Btn_tt_chinhsach.Size = new Size(162, 26);
            Ts_Btn_tt_chinhsach.Text = "Chính sách";
            Ts_Btn_tt_chinhsach.Click += Ts_Btn_tt_chinhsach_Click;
            // 
            // Ts_Btn_tt_diem
            // 
            Ts_Btn_tt_diem.Name = "Ts_Btn_tt_diem";
            Ts_Btn_tt_diem.Size = new Size(162, 26);
            Ts_Btn_tt_diem.Text = "Điểm";
            // 
            // Ts_Btn_timkiem
            // 
            Ts_Btn_timkiem.DropDownItems.AddRange(new ToolStripItem[] { Ts_Btn_tk_khoa, Ts_Btn_tk_giaovien, Ts_Btn_tk_lop, Ts_Btn_tk_sinhvien, Ts_Btn_tk_monhoc, Ts_Btn_tk_chinhsach });
            Ts_Btn_timkiem.Name = "Ts_Btn_timkiem";
            Ts_Btn_timkiem.Size = new Size(84, 24);
            Ts_Btn_timkiem.Text = "Tìm kiếm";
            // 
            // Ts_Btn_tk_khoa
            // 
            Ts_Btn_tk_khoa.Name = "Ts_Btn_tk_khoa";
            Ts_Btn_tk_khoa.Size = new Size(224, 26);
            Ts_Btn_tk_khoa.Text = "Khoa";
            Ts_Btn_tk_khoa.Click += Ts_Btn_tk_khoa_Click;
            // 
            // Ts_Btn_tk_giaovien
            // 
            Ts_Btn_tk_giaovien.Name = "Ts_Btn_tk_giaovien";
            Ts_Btn_tk_giaovien.Size = new Size(224, 26);
            Ts_Btn_tk_giaovien.Text = "Giáo viên";
            Ts_Btn_tk_giaovien.Click += Ts_Btn_tk_giaovien_Click;
            // 
            // Ts_Btn_tk_lop
            // 
            Ts_Btn_tk_lop.Name = "Ts_Btn_tk_lop";
            Ts_Btn_tk_lop.Size = new Size(224, 26);
            Ts_Btn_tk_lop.Text = "Lớp";
            Ts_Btn_tk_lop.Click += Ts_Btn_tk_lop_Click;
            // 
            // Ts_Btn_tk_sinhvien
            // 
            Ts_Btn_tk_sinhvien.Name = "Ts_Btn_tk_sinhvien";
            Ts_Btn_tk_sinhvien.Size = new Size(224, 26);
            Ts_Btn_tk_sinhvien.Text = "Sinh viên";
            Ts_Btn_tk_sinhvien.Click += Ts_Btn_tk_sinhvien_Click;
            // 
            // Ts_Btn_tk_monhoc
            // 
            Ts_Btn_tk_monhoc.Name = "Ts_Btn_tk_monhoc";
            Ts_Btn_tk_monhoc.Size = new Size(224, 26);
            Ts_Btn_tk_monhoc.Text = "Môn học";
            Ts_Btn_tk_monhoc.Click += Ts_Btn_tk_monhoc_Click;
            // 
            // Ts_Btn_tk_chinhsach
            // 
            Ts_Btn_tk_chinhsach.Name = "Ts_Btn_tk_chinhsach";
            Ts_Btn_tk_chinhsach.Size = new Size(224, 26);
            Ts_Btn_tk_chinhsach.Text = "Chính sách";
            Ts_Btn_tk_chinhsach.Click += Ts_Btn_tk_chinhsach_Click;
            // 
            // Ts_capnhatdiem
            // 
            Ts_capnhatdiem.Name = "Ts_capnhatdiem";
            Ts_capnhatdiem.Size = new Size(59, 24);
            Ts_capnhatdiem.Text = "Điểm";
            // 
            // Ts_Btn_quanly
            // 
            Ts_Btn_quanly.DropDownItems.AddRange(new ToolStripItem[] { Ts_Btn_ql_khoa, Ts_Btn_ql_giaovien, Ts_Btn_ql_lop, Ts_Btn_ql_sinhvien, Ts_Btn_ql_monhoc, Ts_Btn_ql_chinhsach, Ts_Btn_ql_diem });
            Ts_Btn_quanly.Name = "Ts_Btn_quanly";
            Ts_Btn_quanly.Size = new Size(73, 24);
            Ts_Btn_quanly.Text = "Quản lý";
            // 
            // Ts_Btn_ql_khoa
            // 
            Ts_Btn_ql_khoa.Name = "Ts_Btn_ql_khoa";
            Ts_Btn_ql_khoa.Size = new Size(162, 26);
            Ts_Btn_ql_khoa.Text = "Khoa";
            Ts_Btn_ql_khoa.Click += Ts_Btn_ql_khoa_Click;
            // 
            // Ts_Btn_ql_giaovien
            // 
            Ts_Btn_ql_giaovien.Name = "Ts_Btn_ql_giaovien";
            Ts_Btn_ql_giaovien.Size = new Size(162, 26);
            Ts_Btn_ql_giaovien.Text = "Giáo viên";
            Ts_Btn_ql_giaovien.Click += Ts_Btn_ql_giaovien_Click;
            // 
            // Ts_Btn_ql_lop
            // 
            Ts_Btn_ql_lop.Name = "Ts_Btn_ql_lop";
            Ts_Btn_ql_lop.Size = new Size(162, 26);
            Ts_Btn_ql_lop.Text = "Lớp";
            Ts_Btn_ql_lop.Click += Ts_Btn_ql_lop_Click;
            // 
            // Ts_Btn_ql_sinhvien
            // 
            Ts_Btn_ql_sinhvien.Name = "Ts_Btn_ql_sinhvien";
            Ts_Btn_ql_sinhvien.Size = new Size(162, 26);
            Ts_Btn_ql_sinhvien.Text = "Sinh viên";
            Ts_Btn_ql_sinhvien.Click += Ts_Btn_ql_sinhvien_Click;
            // 
            // Ts_Btn_ql_monhoc
            // 
            Ts_Btn_ql_monhoc.Name = "Ts_Btn_ql_monhoc";
            Ts_Btn_ql_monhoc.Size = new Size(162, 26);
            Ts_Btn_ql_monhoc.Text = "Môn học";
            Ts_Btn_ql_monhoc.Click += Ts_Btn_ql_monhoc_Click;
            // 
            // Ts_Btn_ql_chinhsach
            // 
            Ts_Btn_ql_chinhsach.Name = "Ts_Btn_ql_chinhsach";
            Ts_Btn_ql_chinhsach.Size = new Size(162, 26);
            Ts_Btn_ql_chinhsach.Text = "Chính sách";
            Ts_Btn_ql_chinhsach.Click += Ts_Btn_ql_chinhsach_Click;
            // 
            // Ts_Btn_ql_diem
            // 
            Ts_Btn_ql_diem.Name = "Ts_Btn_ql_diem";
            Ts_Btn_ql_diem.Size = new Size(162, 26);
            Ts_Btn_ql_diem.Text = "Điểm";
            // 
            // Ts_Btn_hienthi
            // 
            Ts_Btn_hienthi.DropDownItems.AddRange(new ToolStripItem[] { kiểuXemToolStripMenuItem, ngônNgữToolStripMenuItem });
            Ts_Btn_hienthi.Name = "Ts_Btn_hienthi";
            Ts_Btn_hienthi.Size = new Size(75, 24);
            Ts_Btn_hienthi.Text = "Hiển thị";
            // 
            // kiểuXemToolStripMenuItem
            // 
            kiểuXemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trongSuốtToolStripMenuItem, mặcĐịnhToolStripMenuItem });
            kiểuXemToolStripMenuItem.Name = "kiểuXemToolStripMenuItem";
            kiểuXemToolStripMenuItem.Size = new Size(159, 26);
            kiểuXemToolStripMenuItem.Text = "Kiểu xem";
            // 
            // trongSuốtToolStripMenuItem
            // 
            trongSuốtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ts100, ts50 });
            trongSuốtToolStripMenuItem.Name = "trongSuốtToolStripMenuItem";
            trongSuốtToolStripMenuItem.Size = new Size(162, 26);
            trongSuốtToolStripMenuItem.Text = "Trong suốt";
            // 
            // ts100
            // 
            ts100.Name = "ts100";
            ts100.Size = new Size(128, 26);
            ts100.Text = "100%";
            ts100.Click += ts100_Click;
            // 
            // ts50
            // 
            ts50.Name = "ts50";
            ts50.Size = new Size(128, 26);
            ts50.Text = "50%";
            ts50.Click += ts50_Click;
            // 
            // mặcĐịnhToolStripMenuItem
            // 
            mặcĐịnhToolStripMenuItem.Name = "mặcĐịnhToolStripMenuItem";
            mặcĐịnhToolStripMenuItem.Size = new Size(162, 26);
            mặcĐịnhToolStripMenuItem.Text = "Mặc định";
            mặcĐịnhToolStripMenuItem.Click += mặcĐịnhToolStripMenuItem_Click;
            // 
            // ngônNgữToolStripMenuItem
            // 
            ngônNgữToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tiếngViệtToolStripMenuItem, tiếngAnhToolStripMenuItem });
            ngônNgữToolStripMenuItem.Name = "ngônNgữToolStripMenuItem";
            ngônNgữToolStripMenuItem.Size = new Size(159, 26);
            ngônNgữToolStripMenuItem.Text = "Ngôn ngữ";
            // 
            // tiếngViệtToolStripMenuItem
            // 
            tiếngViệtToolStripMenuItem.Name = "tiếngViệtToolStripMenuItem";
            tiếngViệtToolStripMenuItem.Size = new Size(159, 26);
            tiếngViệtToolStripMenuItem.Text = "Tiếng Việt";
            // 
            // tiếngAnhToolStripMenuItem
            // 
            tiếngAnhToolStripMenuItem.Name = "tiếngAnhToolStripMenuItem";
            tiếngAnhToolStripMenuItem.Size = new Size(159, 26);
            tiếngAnhToolStripMenuItem.Text = "Tiếng Anh";
            // 
            // Ts_Btn_tienich
            // 
            Ts_Btn_tienich.DropDownItems.AddRange(new ToolStripItem[] { paintToolStripMenuItem, cmdToolStripMenuItem, npToolStripMenuItem, maytinhToolStripMenuItem, wordToolStripMenuItem });
            Ts_Btn_tienich.Name = "Ts_Btn_tienich";
            Ts_Btn_tienich.Size = new Size(74, 24);
            Ts_Btn_tienich.Text = "Tiện ích";
            // 
            // paintToolStripMenuItem
            // 
            paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            paintToolStripMenuItem.Size = new Size(193, 26);
            paintToolStripMenuItem.Text = "Paint";
            paintToolStripMenuItem.Click += paintToolStripMenuItem_Click;
            // 
            // cmdToolStripMenuItem
            // 
            cmdToolStripMenuItem.Name = "cmdToolStripMenuItem";
            cmdToolStripMenuItem.Size = new Size(193, 26);
            cmdToolStripMenuItem.Text = "Cmd";
            cmdToolStripMenuItem.Click += cmdToolStripMenuItem_Click;
            // 
            // npToolStripMenuItem
            // 
            npToolStripMenuItem.Name = "npToolStripMenuItem";
            npToolStripMenuItem.Size = new Size(193, 26);
            npToolStripMenuItem.Text = "Notepad";
            npToolStripMenuItem.Click += npToolStripMenuItem_Click;
            // 
            // maytinhToolStripMenuItem
            // 
            maytinhToolStripMenuItem.Name = "maytinhToolStripMenuItem";
            maytinhToolStripMenuItem.Size = new Size(193, 26);
            maytinhToolStripMenuItem.Text = "Máy tính";
            maytinhToolStripMenuItem.Click += maytinhToolStripMenuItem_Click;
            // 
            // wordToolStripMenuItem
            // 
            wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            wordToolStripMenuItem.Size = new Size(193, 26);
            wordToolStripMenuItem.Text = "Microsoft word";
            wordToolStripMenuItem.Click += wordToolStripMenuItem_Click;
            // 
            // hỗTrợToolStripMenuItem
            // 
            hỗTrợToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { liênHệToolStripMenuItem, thôngTinToolStripMenuItem1, cậpNhậtPhầnMềmToolStripMenuItem });
            hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            hỗTrợToolStripMenuItem.Size = new Size(66, 24);
            hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // liênHệToolStripMenuItem
            // 
            liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            liênHệToolStripMenuItem.Size = new Size(226, 26);
            liênHệToolStripMenuItem.Text = "Liên hệ";
            liênHệToolStripMenuItem.Click += liênHệToolStripMenuItem_Click;
            // 
            // thôngTinToolStripMenuItem1
            // 
            thôngTinToolStripMenuItem1.Name = "thôngTinToolStripMenuItem1";
            thôngTinToolStripMenuItem1.Size = new Size(226, 26);
            thôngTinToolStripMenuItem1.Text = "Thông tin";
            thôngTinToolStripMenuItem1.Click += thôngTinToolStripMenuItem1_Click;
            // 
            // cậpNhậtPhầnMềmToolStripMenuItem
            // 
            cậpNhậtPhầnMềmToolStripMenuItem.Name = "cậpNhậtPhầnMềmToolStripMenuItem";
            cậpNhậtPhầnMềmToolStripMenuItem.Size = new Size(226, 26);
            cậpNhậtPhầnMềmToolStripMenuItem.Text = "Cập nhật phần mềm";
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(61, 24);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lb_time
            // 
            lb_time.AutoSize = true;
            lb_time.BackColor = Color.Transparent;
            lb_time.Location = new Point(0, 39);
            lb_time.Name = "lb_time";
            lb_time.Size = new Size(0, 20);
            lb_time.TabIndex = 2;
            // 
            // lb_ten
            // 
            lb_ten.AutoSize = true;
            lb_ten.BackColor = Color.Transparent;
            lb_ten.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_ten.Location = new Point(172, 84);
            lb_ten.Name = "lb_ten";
            lb_ten.Size = new Size(477, 25);
            lb_ten.TabIndex = 3;
            lb_ten.Text = "Trường Đại học Kinh tế Kỹ thuật Công nghiệp";
            lb_ten.Click += lb_ten_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_ten);
            Controls.Add(lb_time);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public MenuStrip menuStrip1;
        public ToolStripMenuItem Ts_Btn_hethong;
        public ToolStripMenuItem Ts_Btn_admin;
        public ToolStripMenuItem Ts_truongkhoa;
        public ToolStripMenuItem ts_gv;
        public ToolStripMenuItem Ts_Btn_user;
        public ToolStripSeparator toolStripSeparator1;
        public ToolStripMenuItem Ts_Btn_khoa;
        public ToolStripMenuItem Ts_Btn_doimatkhau;
        public ToolStripSeparator đăngXuấtToolStripMenuItem;
        public ToolStripMenuItem Ts_Btn_dangnhap;
        public ToolStripMenuItem Ts_Btn_thongtin;
        public ToolStripMenuItem Ts_Btn_tt_khoa;
        public ToolStripMenuItem Ts_Btn_tt_giaovien;
        public ToolStripMenuItem Ts_Btn_tt_lop;
        public ToolStripMenuItem Ts_Btn_tt_sinhvien;
        public ToolStripMenuItem Ts_Btn_tt_monhoc;
        public ToolStripMenuItem Ts_Btn_tt_chinhsach;
        public ToolStripMenuItem Ts_Btn_tt_diem;
        public ToolStripMenuItem Ts_Btn_timkiem;
        public ToolStripMenuItem Ts_Btn_tk_khoa;
        public ToolStripMenuItem Ts_Btn_tk_giaovien;
        public ToolStripMenuItem Ts_Btn_tk_lop;
        public ToolStripMenuItem Ts_Btn_tk_sinhvien;
        public ToolStripMenuItem Ts_Btn_tk_monhoc;
        public ToolStripMenuItem Ts_capnhatdiem;
        public ToolStripMenuItem Ts_Btn_quanly;
        public ToolStripMenuItem Ts_Btn_hienthi;
        public ToolStripMenuItem Ts_Btn_ql_khoa;
        public ToolStripMenuItem Ts_Btn_ql_giaovien;
        public ToolStripMenuItem Ts_Btn_ql_lop;
        public ToolStripMenuItem Ts_Btn_ql_sinhvien;
        public ToolStripMenuItem Ts_Btn_ql_monhoc;
        public ToolStripMenuItem Ts_Btn_ql_chinhsach;
        public ToolStripMenuItem Ts_Btn_ql_diem;
        public ToolStripMenuItem kiểuXemToolStripMenuItem;
        public ToolStripMenuItem trongSuốtToolStripMenuItem;
        public ToolStripMenuItem mặcĐịnhToolStripMenuItem;
        public ToolStripMenuItem ngônNgữToolStripMenuItem;
        public ToolStripMenuItem tiếngViệtToolStripMenuItem;
        public ToolStripMenuItem tiếngAnhToolStripMenuItem;
        public ToolStripMenuItem Ts_Btn_tienich;
        public ToolStripMenuItem paintToolStripMenuItem;
        public ToolStripMenuItem cmdToolStripMenuItem;
        public ToolStripMenuItem npToolStripMenuItem;
        public ToolStripMenuItem maytinhToolStripMenuItem;
        public ToolStripMenuItem hỗTrợToolStripMenuItem;
        public ToolStripMenuItem thoatToolStripMenuItem;
        public ToolStripMenuItem wordToolStripMenuItem;
        public ToolStripMenuItem liênHệToolStripMenuItem;
        public ToolStripMenuItem thôngTinToolStripMenuItem1;
        public ToolStripMenuItem cậpNhậtPhầnMềmToolStripMenuItem;
        public ToolStripMenuItem Ts_Btn_tk_chinhsach;
        public System.Windows.Forms.Timer timer1;
        public Label lb_time;
        public Label lb_ten;
        private System.Windows.Forms.Timer timer2;
        public ToolStripMenuItem Ts_Btn_dangxuat;
        private ToolStripMenuItem ts100;
        private ToolStripMenuItem ts50;
    }
}