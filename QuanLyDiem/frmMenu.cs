using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
namespace QuanLyDiem
{
    public partial class frmMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMenu(Account account)
        {
            InitializeComponent();
        }

        
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Blue"; // giao diện mặc định khi mở chương trình
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            skins();
        }
        public void ViewChildForm(Form _form)
        {
            //Check before open
            if (!IsFormActived(_form))
            {
                _form.MdiParent = this;
                _form.Show();
            }
        }
        //Check if a form is opened already      
        private bool IsFormActived(Form form)
        {
            
            bool IsOpenend = false;
            //If there is more than one form opened
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        //Active this form
                        MdiManager.Pages[item].MdiChild.Activate();
                        IsOpenend = true;
                    }
                }
            }
            return IsOpenend;
        }
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr;
            dlr = XtraMessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                Application.Exit();
            }
        }
        
        private void btnLogIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        private void btnMonhoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            ViewChildForm(frm);


        }

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoa frm = new frmKhoa();
            
            ViewChildForm(frm);
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLop frm = new frmLop();
            
            ViewChildForm(frm);
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr;
            dlr = XtraMessageBox.Show("Bạn có muốn đăng nhập lại?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                  this.Hide();
            }
            if(dlr == DialogResult.No)
            {
                Application.Exit();
            }
          
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSinhVien frm = new frmSinhVien();
            ViewChildForm(frm);
        }

        private void btnGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGiangvien frm = new frmGiangvien();
            ViewChildForm(frm);
        }
    }
}
