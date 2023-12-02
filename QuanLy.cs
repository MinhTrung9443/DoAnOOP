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
    public partial class QuanLy : Form
    {
        public delegate void chuyen(int a);
        public chuyen truyen;
        Librarian mem = new Librarian();
        qlyBook book;
        database_DoAnDataContext db = new database_DoAnDataContext();
        public QuanLy(Librarian x)
        {
            InitializeComponent();
            mem = x;
            lbl_ten.Text = mem.Name;
            lbl_id.Text = mem.Id.ToString();
            lbl_contact.Text = mem.NumberContact.ToString();
            lbl_address.Text = mem.Address;
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'do_an_oopDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.do_an_oopDataSet.Book);
            var l = (from a in db.qlyBooks select a).ToList();
            dataGridView1.DataSource= l;
        }

        private void add(Book a, object sender, EventArgs e)
        {
            book = new qlyBook();
            try
            {
                mem.addBook(a);
            }
            catch
            {
                MessageBox.Show("Loi dang trong qua trinh fix.");
            }
            QuanLy_Load(sender, e);
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            QuanLy_Load(sender, e);
            Form_ttSach a = new Form_ttSach();
            a.truyen = new Form_ttSach.truyenDuLieu(add);
            a.ShowDialog();
        }
        private void search(string a, string b)
        {
            var list = mem.searchBook(a, b);
            if (list.Count > 0)
            {
                dataGridView1.DataSource = list;
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("Khong tim thay trong thu vien.");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (truyen != null)
            {
                truyen(1);
            }
            Close();
        }

        private void btn_search_librarian_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.truyen = new Form3.truyenDuLieu(search);
            a.ShowDialog();
        }

        private void btn_viewMember_Click(object sender, EventArgs e)
        {
            ViewMember a = new ViewMember();
            a.ShowDialog();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            report a = new report();
            a.ShowDialog();
        }
    }
}
