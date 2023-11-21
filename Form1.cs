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
    public partial class Form1 : Form
    {
        qlyBook book ;
        qlyMember member = new qlyMember();
        database_DoAnDataContext db = new database_DoAnDataContext();
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();
        Member mem = new Member();
        public Form1()
        {
            InitializeComponent();
        }
        private void input()
        {
            var list = (from s in db.qlyBooks select s).ToList();
            foreach (var item in list)
            {
                Book a = new Book();
                a.BookCode = item.BookCode;
                a.Name = item.BookName;
                a.Author = item.Author;
                a.Date = (DateTime)item.Date;
                a.Number = (int)item.Number;
                books.Add(a);
            }
            var list2 = (from s in db.qlyMembers select s).ToList();
            foreach (var item in list2)
            {
                Member b = new Member();
                b.Id = item.Id;
                b.Address = item.Address;
                b.NumberContact = (int)item.Number;
                b.Name = item.Name;
                members.Add(b);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'do_an_oopDataSet.Book' table. You can move, or remove it, as needed.
            this.do_an_oopDataSet.Tables.Clear();
            this.bookTableAdapter.Fill(this.do_an_oopDataSet.Book);
            var list = (from s in db.qlyBooks select s).ToList();
            dataGridView1.DataSource = list;
            input();
        }
        private void add(Book a, object sender, EventArgs e)
        {
            try
            {
                book = new qlyBook();
                int i = 0;
                for (i = 0; i < books.Count; i++)
                {
                    if (books[i].BookCode == a.BookCode && books[i].Author.CompareTo(a.Author) == 0)
                    {
                        book = db.qlyBooks.Where(x => x.BookCode == a.BookCode).Single();
                        book.Number += 1;
                        db.SubmitChanges();
                        break;
                    }
                    if (books[i].BookCode == a.BookCode && books[i].Author.CompareTo(a.Author) != 0)
                    {
                        MessageBox.Show("Ma sach da ton tai. Moi nhap lai thong tin sach!");
                        break;
                    }
                }
                if (i == books.Count)
                {
                    book.Author = a.Author;
                    book.Date = a.Date;
                    book.BookCode = a.BookCode;
                    book.BookName = a.Name;
                    book.Number = 0;
                    db.qlyBooks.InsertOnSubmit(book);
                    db.SubmitChanges();
                }
                Form1_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Loi dang trong qua trinh fix.");
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.truyen = new Form2.truyenDuLieu(add);
            a.ShowDialog();
        }

        private void btn_viewMember_Click(object sender, EventArgs e)
        {
            string a = "";
            for (int i = 0;i<members.Count;i++)
            {
                a += members[i].printfDetail();
            }
            MessageBox.Show(a);
        }

        private void search(string a,string b)
        {
            int temp = int.Parse(a);
            var list = (from m in db.qlyBooks where m.BookCode == temp && m.BookName.CompareTo(b) == 0 select m).ToList();    
            if (list.Count > 0)
            {
                this.do_an_oopDataSet.Tables.Clear();
                this.bookTableAdapter.Fill(this.do_an_oopDataSet.Book);
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("Khong tim thay trong thu vien.");
            }

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

        static int temp = 3;
        private void login(string a,string b)
        {
            if (a.CompareTo("Admin") == 0 && b.CompareTo("123456") == 0)
            {
                grBox_libra.Visible = true;
                grBox_mem.Visible = false;
                lbl_hienThi.Text = "Quan tri vien";
                lbl_hienThi.Visible = true;
            }
            else
                temp--;

        }
        private void btn_librarian_Click(object sender, EventArgs e)
        {
            if(temp > 0)
            {
                Form3 a = new Form3();
                a.reName();
                a.truyen = new Form3.truyenDuLieu(login);
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ban da het so lan thu");
            }
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            lbl_hienThi.Text = "Nguoi dung " + mem.ToString();
            lbl_hienThi.Visible = true;
            grBox_libra.Visible = false;
            grBox_mem.Visible = true;
        }
    }
}
