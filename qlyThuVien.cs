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
        //qlyLogin log;
        qlyMember member;
        database_DoAnDataContext db = new database_DoAnDataContext();

        Member mem = new Member();
        List<Book> books = new List<Book>();
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
                var list = (from k in db.qlyBooks where k.BookCode == a.BookCode select k).ToList();
                if (list.Count > 0)
                {
                    qlyBook temp = new qlyBook();
                    temp = db.qlyBooks.Where(s => s.BookCode == a.BookCode).Single();
                    if (a.Name.CompareTo(temp.BookName) == 0 && a.Author.CompareTo(temp.Author) == 0
                    && a.Date == temp.Date)
                    {
                        int x = (int)temp.Number;
                        x += 1;
                        temp.Number = x;
                        db.SubmitChanges();
                        MessageBox.Show("Thong tin sach: \n" + a.bookDetail(), "Them sach thanh cong.");
                    }
                    else if (a.Name.CompareTo(temp.BookName) != 0)
                    {
                        MessageBox.Show("Da ton tai ma sach.");
                    }
                }
                else
                {
                    book.Author = a.Author;
                    book.Date = a.Date;
                    book.BookCode = a.BookCode;
                    book.BookName = a.Name;
                    book.Number = 1;
                    db.qlyBooks.InsertOnSubmit(book);
                    db.SubmitChanges();
                    MessageBox.Show("Thong tin sach: \n" + a.bookDetail(), "Them sach thanh cong.");
                }
            }
            catch
            {
                MessageBox.Show("Loi dang trong qua trinh fix.");
            }
            Form1_Load(sender, e);
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Form_ttSach a = new Form_ttSach();
            a.truyen = new Form_ttSach.truyenDuLieu(add);
            a.ShowDialog();
        }
        private void search(string a,string b)
        {
            int temp;
            try
            {
                temp = int.Parse(a);
            }
            catch
            {
                MessageBox.Show("Moi nhap ma sach la mot so nguyen.");
                return;
            }
            var list = (from m in db.qlyBooks where m.BookCode == temp && m.BookName.CompareTo(b) == 0 select m).ToList();    
            if (list.Count > 0)
            {
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
            Form1_Load(sender, e);
        }
        private void nguoiDung(Member a, object sender, EventArgs e)
        {
            mem = a;
        }
        private void btn_member_Click(object sender, EventArgs e)
        {
            Thong_tin a = new Thong_tin();
            a.truyen = new Thong_tin.truyenDuLieu(nguoiDung);
            a.ShowDialog();
            lbl_hienThi.Text = "Nguoi dung " + mem.printfDetail();
            lbl_hienThi.Visible = true;
            grBox_libra.Visible = false;
            grBox_mem.Visible = true;
            Form1_Load(sender, e);
        }
        private void muonSach(string a, string b)
        {
            int x = new int();
            try
            {
                x = int.Parse(a);
            }
            catch
            {
                MessageBox.Show("Moi nhap Id la mot so nguyen");
            }
            book = new qlyBook();
            var list = (from k in db.qlyBooks where k.BookCode == x && b.CompareTo(k.BookName) == 0 select k).ToList();
            if (list.Count > 0)
            {
                book = db.qlyBooks.Where(s => s.BookCode == x && b.CompareTo(s.BookName) == 0).First();
                if ((int)book.Number == 0)
                {
                    MessageBox.Show("Sach da het");
                    return;
                }
                else
                {
                    member = new qlyMember();
                    int y = (int)book.Number - 1;
                    book.Number = y;
                    var l = (from k in db.qlyMembers where k.Id == mem.Id && k.BookCode == x select k).ToList();
                    if (l.Count > 0)
                    {
                        member = db.qlyMembers.Where(k => k.Id == mem.Id && k.BookCode == x).First();
                        int temp = (int)member.BookNumber;
                        member.Number = temp + 1;
                        db.SubmitChanges();
                        MessageBox.Show("Da muon sach xong");
                        return;
                    }
                    else
                    {
                        member.Name = mem.Name;
                        member.Address = mem.Address;
                        member.Id = mem.Id;
                        member.Number = mem.NumberContact;
                        member.BookCode = book.BookCode;
                        member.BookName = book.BookName;
                        member.BookNumber = 1;
                        member.stt = (int)db.qlyMembers.Max(k => k.stt) + 1;
                        db.qlyMembers.InsertOnSubmit(member);
                        db.SubmitChanges();
                        MessageBox.Show("Da muon sach xong");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Khong ton tai sach trong thu vien");
            }
        }
        private void btn_issue_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.truyen = new Form3.truyenDuLieu(muonSach);
            a.ShowDialog();
            Form1_Load(sender, e);
        }
        private void traSach(string a,string b)
        {
            int x = new int();
            try
            {
                x = int.Parse(a);
            }
            catch
            {
                MessageBox.Show("Moi nhap Id la mot so nguyen");
            }
            book = new qlyBook();
            member = new qlyMember();
            var list = (from k in db.qlyMembers where k.BookCode == x && k.BookName.CompareTo(b) == 0 && mem.Name.CompareTo(k.Name) == 0 select k).ToList();
            if (list.Count > 0)
            {
                book = db.qlyBooks.Where(s => s.BookCode == x && b.CompareTo(s.BookName) == 0).First();
                int temp = (int)book.Number;
                book.Number = temp + 1;
                member = db.qlyMembers.Where(s => s.BookCode == x).First();
                if ((int)member.Number > 1)
                {
                    int ta = (int)member.Number;
                    member.Number = ta - 1;
                }
                else
                {
                    db.qlyMembers.DeleteOnSubmit(member);
                }
                db.SubmitChanges();
                MessageBox.Show("Da tra sach xong");
            }
            else
            {
                MessageBox.Show("Khong tra sach duoc");
            }
        }
        private void btn_return_Click(object sender, EventArgs e)
        {
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

        private void btn_report_Click(object sender, EventArgs e)
        {
            TextWriter wtr = new StreamWriter(@"D:\\Report.txt");
            wtr.WriteLine("\tId \t Name  \t\t Address \t\t NumberContact \t\t BookCode \t\t BookName \t\t BookNumber \n");
            var list = (from a in db.qlyMembers select a).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                wtr.WriteLine("" + list[i].Id + "\t" + list[i].Name + "\t" + list[i].Address + "\t" + list[i].Number);
            }
            wtr.Close();
        }
    }
}
