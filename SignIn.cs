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
    }
}
