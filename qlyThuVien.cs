using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private void add(Book a, object sender, EventArgs e)
        {
            book = new qlyBook();
            try
            {
                Librarian temp = new Librarian();
                temp.addBook(a);
                Form1_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Loi dang trong qua trinh fix.");
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Form_ttSach a = new Form_ttSach();
            a.truyen = new Form_ttSach.truyenDuLieu(add);
            Form1_Load(sender, e);
            a.ShowDialog();
        }
        private void search(string a,string b)
        {
            Librarian x = new Librarian();
            var list = x.searchBook(a, b); 
            if (list.Count > 0)
            {
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("Khong tim thay trong thu vien.");
            }
            dataGridView1.Visible = true;
        }
        private void btn_search_librarian_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.truyen = new Form3.truyenDuLieu(search);
            a.ShowDialog();

        }
        private void btn_search_member_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.truyen = new Form3.truyenDuLieu(search);
            a.ShowDialog();
        }
        
        private void muonSach(string a,string b)
        {
            Member temp = new Member();
            temp.issueBook(a, b,(Member)mem);
        }
        private void btn_issue_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible= false;
            Form3 a = new Form3();
            a.truyen = new Form3.truyenDuLieu(muonSach);
            a.ShowDialog();
            Form1_Load(sender, e);
        }
        private void traSach(string a,string b)
        {
            Member temp = new Member();
            temp.returnBook(a, b, (Member)mem);
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            Form3 a = new Form3();
            
            a.truyen = new Form3.truyenDuLieu(traSach);
            a.ShowDialog();
            Form1_Load(sender,e);
        }

        private void btn_viewMember_Click(object sender, EventArgs e)
        {
            ViewMember a = new ViewMember();
            a.ShowDialog();
        }
        /// <summary>
        ///  chức năng dưới này chưa có xong hú hú hú hú hú hú hú 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_report_Click(object sender, EventArgs e)
        {
            report a = new report();
            a.ShowDialog();
        }
        private void thucthi(string a,string b)
        {
            var l = (from s in db.qlyLogins where a.CompareTo(s.TenDangNhap) == 0 && b.CompareTo(s.Key) == 0 select s).ToList();    
            if (l.Count == 1)
            {
                foreach(qlyLogin t in l)
                {
                    if (t.check == 1)
                    {
                        mem = new Librarian(t.Name, (int)t.NumberContact, t.Address, (int)t.Id);
                        dataGridView1.Visible = true;
                        grBox_libra.Visible = true;
                        grBox_mem.Visible = false;
                        lbl_hienThi.Text = "Nguoi quan ly " + mem.printfDetail();
                        lbl_hienThi.Visible = true;
                    }
                    else
                    {
                        mem = new Member(t.Name, (int)t.NumberContact, t.Address, (int)t.Id);
                        dataGridView1.Visible = false;
                        grBox_libra.Visible = false;
                        grBox_mem.Visible = true;
                        lbl_hienThi.Text = "Nguoi dung " + mem.printfDetail();
                        lbl_hienThi.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Tai khoan khong ton tai. Moi dang nhap lai.");
                return;
            }
        }
        private void btn_signUp_Click(object sender, EventArgs e)
        {
            signUp a = new signUp();
            a.truyen = new signUp.truyenDuLieu(thucthi);
            a.ShowDialog();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.reName();
            a.truyen = new Form3.truyenDuLieu(thucthi);
            a.ShowDialog();
        }
    }
}
