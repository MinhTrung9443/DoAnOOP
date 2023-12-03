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
    public partial class NguoiDung : Form
    {
        public delegate void chuyen(int a);
        public chuyen truyen;

        Member mem = new Member();
        database_DoAnDataContext db;
        public NguoiDung(Member x)
        {
            InitializeComponent();
            mem = x;
            lbl_ten.Text = mem.Name;
            lbl_id.Text = mem.Id.ToString();
            lbl_contact.Text = mem.NumberContact.ToString();
            lbl_address.Text = mem.Address;
        }
        private void NguoiDung_Load(object sender, EventArgs e)
        {
            db = new database_DoAnDataContext();
            var l = (from a in db.qlyBooks select a).ToList();
            dataGridView1.DataSource = l;
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (truyen!= null)
            {
                truyen(1);
            }
            Close();
        }
        private void traSach(string a, string b)
        {
            mem.returnBook(a, b, mem);
        }
        private void btn_return_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            dataGridView1.Visible = false;
            Form3 a = new Form3();

            a.truyen = new Form3.truyenDuLieu(traSach);
            a.ShowDialog();
            NguoiDung_Load(sender, e);
        }

        private void search(string a, string b)
        {
            var list = mem.searchBook(a, b);
            if (list.Count > 0)
            {
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("Khong tim thay trong thu vien.");
                return;
            }
            label1.Visible = true;
            dataGridView1.Visible = true;
        }
        private void btn_search_member_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.truyen = new Form3.truyenDuLieu(search);
            a.ShowDialog();
        }
        private void muonSach(string a, string b)
        {
            mem.issueBook(a, b, mem);
        }
        private void btn_issue_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            dataGridView1.Visible = false;
            Form3 a = new Form3();
            a.truyen = new Form3.truyenDuLieu(muonSach);
            a.ShowDialog();
            NguoiDung_Load(sender, e);
        }
    }
}
