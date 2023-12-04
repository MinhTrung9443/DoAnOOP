using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP
{
    public partial class qlyThuVien : Form
    {
        qlyBook book;
        qlyMember member;
        qlytraSach sachtra;
        database_DoAnDataContext db = new database_DoAnDataContext();
        Person mem;
        public qlyThuVien()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'do_an_oopDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.do_an_oopDataSet.Book);
        }
        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            panelDesktopPane.Size = childForm.Size;
            panelDesktopPane.BringToFront();
            childForm.Show();
        }
        private void an(int a)
        {
            panelDesktopPane.SendToBack();
        }
        private void thucthi(string a,string b)
        {
            try
            {
                qlyLogin t = db.qlyLogins.Where(s => a.CompareTo(s.TenDangNhap) == 0 && b.CompareTo(s.Key) == 0).First();
                if ((int)t.check == 1)
                {
                    mem = new Librarian(t.Name, (int)t.NumberContact, t.Address, (int)t.Id);
                    QuanLy m = new QuanLy((Librarian)mem);
                    m.truyen = new QuanLy.chuyen(an);
                    OpenChildForm(m);
                }
                else
                {
                    mem = new Member(t.Name, (int)t.NumberContact, t.Address, (int)t.Id);
                    NguoiDung m = new NguoiDung((Member)mem);
                    m.truyen = new NguoiDung.chuyen(an);
                    OpenChildForm(m);
                }
            }
            catch
            {
                MessageBox.Show("Tai khoan khong ton tai. Moi dang nhap lai.");
                return;
            }
        }


        private void btn_signIn_Click(object sender, EventArgs e)
        {
            SignIn a = new SignIn();
            a.truyen = new SignIn.truyenDuLieu(thucthi);
            a.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

    }
}
