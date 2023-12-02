using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP
{
    public partial class SignIn : Form
    {
        public delegate void truyenDuLieu(string a, string b);
        public truyenDuLieu truyen;
        public SignIn()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (truyen != null)
            {
                truyen(tbx_tdn.Text, tbx_matkhau.Text);
            }
            Close();
        }

        private void thucThi(string a,string b)
        {
            if (truyen != null)
            {
                truyen(a, b);
            }
            Close();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUp a = new signUp();
            a.truyen = new signUp.truyenDuLieu(thucThi);
            a.ShowDialog();
        }
        private void thucThi(string a,string b,string c,string d)
        {
            database_DoAnDataContext db = new database_DoAnDataContext();
            try
            {
                qlyLogin x = db.qlyLogins.Where(s => s.Name == a && s.Id == int.Parse(b) && s.NumberContact == int.Parse(c) && s.Address == d).First();
                tbx_tdn.Text = x.TenDangNhap;
                tbx_matkhau.Text = x.Key;
            }
            catch
            {
                MessageBox.Show("Thong tin sai hoac ban chua co tai khoan.");
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thong_tin a = new Thong_tin();
            a.truyen = new Thong_tin.truyenDuLieu(thucThi);
            a.ShowDialog();
        }
    }
}
