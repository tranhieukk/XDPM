namespace QuanLyDiem
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnRole = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnMonhoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiemmonhoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnThiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoclai = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSSVThiLai = new DevExpress.XtraBars.BarButtonItem();
            this.hocKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiemRenLuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnBieuMau = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.MdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLogIn,
            this.btnChangePass,
            this.btnLogOut,
            this.btnRole,
            this.skinRibbonGalleryBarItem1,
            this.btnMonhoc,
            this.btnKhoa,
            this.btnLop,
            this.btnSinhVien,
            this.btnGiangVien,
            this.btnDiemmonhoc,
            this.btnThiLai,
            this.btnHoclai,
            this.btnDSSVThiLai,
            this.hocKy,
            this.btnHocKy,
            this.btnDiemRenLuyen,
            this.btnBieuMau,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.rbHeThong,
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Caption = "Đăng nhập";
            this.btnLogIn.Id = 1;
            this.btnLogIn.LargeGlyph = global::QuanLyDiem.Properties.Resources.User_Interface_Login_icon;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogIn_ItemClick);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Caption = "Đổi mật khẩu";
            this.btnChangePass.Id = 2;
            this.btnChangePass.LargeGlyph = global::QuanLyDiem.Properties.Resources.keyring_icon;
            this.btnChangePass.Name = "btnChangePass";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 3;
            this.btnLogOut.LargeGlyph = global::QuanLyDiem.Properties.Resources.logout_icon;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // btnRole
            // 
            this.btnRole.Caption = "Thành viên";
            this.btnRole.Id = 4;
            this.btnRole.LargeGlyph = global::QuanLyDiem.Properties.Resources.user;
            this.btnRole.Name = "btnRole";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 5;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnMonhoc
            // 
            this.btnMonhoc.Caption = "Môn học";
            this.btnMonhoc.Id = 6;
            this.btnMonhoc.LargeGlyph = global::QuanLyDiem.Properties.Resources.book_icon;
            this.btnMonhoc.Name = "btnMonhoc";
            this.btnMonhoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonhoc_ItemClick);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Caption = "Khoa";
            this.btnKhoa.Id = 7;
            this.btnKhoa.LargeGlyph = global::QuanLyDiem.Properties.Resources.Black_board_icon;
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoa_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 8;
            this.btnLop.LargeGlyph = global::QuanLyDiem.Properties.Resources.if_board_math_class_school_2824448;
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh viên";
            this.btnSinhVien.Id = 9;
            this.btnSinhVien.LargeGlyph = global::QuanLyDiem.Properties.Resources.user1;
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Caption = "Giảng viên";
            this.btnGiangVien.Id = 10;
            this.btnGiangVien.LargeGlyph = global::QuanLyDiem.Properties.Resources.Administrator_icon;
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiangVien_ItemClick);
            // 
            // btnDiemmonhoc
            // 
            this.btnDiemmonhoc.Caption = "Điểm môn học";
            this.btnDiemmonhoc.Id = 11;
            this.btnDiemmonhoc.LargeGlyph = global::QuanLyDiem.Properties.Resources._79360_204030_paper_test;
            this.btnDiemmonhoc.Name = "btnDiemmonhoc";
            // 
            // btnThiLai
            // 
            this.btnThiLai.Caption = "Thi lại";
            this.btnThiLai.Id = 12;
            this.btnThiLai.LargeGlyph = global::QuanLyDiem.Properties.Resources.icons8_test_passed_50;
            this.btnThiLai.Name = "btnThiLai";
            // 
            // btnHoclai
            // 
            this.btnHoclai.Caption = "Học lại";
            this.btnHoclai.Id = 13;
            this.btnHoclai.LargeGlyph = global::QuanLyDiem.Properties.Resources.book_icon;
            this.btnHoclai.Name = "btnHoclai";
            // 
            // btnDSSVThiLai
            // 
            this.btnDSSVThiLai.Caption = "Danh sách sinh viên thi lại";
            this.btnDSSVThiLai.Id = 14;
            this.btnDSSVThiLai.LargeGlyph = global::QuanLyDiem.Properties.Resources.Data_List_icon;
            this.btnDSSVThiLai.Name = "btnDSSVThiLai";
            // 
            // hocKy
            // 
            this.hocKy.Caption = "Học kỳ";
            this.hocKy.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.hocKy.Id = 15;
            this.hocKy.LargeGlyph = global::QuanLyDiem.Properties.Resources.icons8_class_48;
            this.hocKy.Name = "hocKy";
            // 
            // btnHocKy
            // 
            this.btnHocKy.Caption = "Học kỳ";
            this.btnHocKy.Id = 16;
            this.btnHocKy.LargeGlyph = global::QuanLyDiem.Properties.Resources.icons8_test_passed_50;
            this.btnHocKy.Name = "btnHocKy";
            // 
            // btnDiemRenLuyen
            // 
            this.btnDiemRenLuyen.Caption = "Điểm rèn luyện";
            this.btnDiemRenLuyen.Id = 17;
            this.btnDiemRenLuyen.LargeGlyph = global::QuanLyDiem.Properties.Resources.icons8_class_48;
            this.btnDiemRenLuyen.Name = "btnDiemRenLuyen";
            // 
            // btnBieuMau
            // 
            this.btnBieuMau.Caption = "Danh sách sinh viên";
            this.btnBieuMau.Id = 18;
            this.btnBieuMau.LargeGlyph = global::QuanLyDiem.Properties.Resources.Data_List_icon;
            this.btnBieuMau.Name = "btnBieuMau";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Danh sách môn học";
            this.barButtonItem1.Id = 19;
            this.barButtonItem1.LargeGlyph = global::QuanLyDiem.Properties.Resources.book_icon;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Bảng điểm cá nhân";
            this.barButtonItem2.Id = 20;
            this.barButtonItem2.LargeGlyph = global::QuanLyDiem.Properties.Resources._79360_204030_paper_test;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Danh sách học bổng";
            this.barButtonItem3.Id = 21;
            this.barButtonItem3.LargeGlyph = global::QuanLyDiem.Properties.Resources.icons8_test_passed_50;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Tiêu chí rèn luyện";
            this.barButtonItem4.Id = 23;
            this.barButtonItem4.LargeGlyph = global::QuanLyDiem.Properties.Resources.icons8_class_48;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhoa);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMonhoc);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHocKy);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Danh mục";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Quản lý";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSinhVien);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDiemmonhoc);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDiemRenLuyen);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnRole);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBieuMau);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnThiLai);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnHoclai);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Biểu mẫu";
            // 
            // rbHeThong
            // 
            this.rbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Tài khoản";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogIn);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePass);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Truy cập";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Cài đặt";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Giao diện";
            // 
            // MdiManager
            // 
            this.MdiManager.MdiParent = this;
            // 
            // frmMenu
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 549);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUẢN LÝ ĐIỂM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnLogIn;
        private DevExpress.XtraBars.BarButtonItem btnChangePass;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnRole;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnMonhoc;
        private DevExpress.XtraBars.BarButtonItem btnKhoa;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnGiangVien;
        private DevExpress.XtraBars.BarButtonItem btnDiemmonhoc;
        private DevExpress.XtraBars.BarButtonItem btnThiLai;
        private DevExpress.XtraBars.BarButtonItem btnHoclai;
        private DevExpress.XtraBars.BarButtonItem btnDSSVThiLai;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MdiManager;
        private DevExpress.XtraBars.BarButtonItem hocKy;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem btnHocKy;
        private DevExpress.XtraBars.BarButtonItem btnDiemRenLuyen;
        private DevExpress.XtraBars.BarButtonItem btnBieuMau;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}

