using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
namespace DoAnOOP
{
    public class Librarian : Person, ILibrarian
    {
        qlyBook book;
        database_DoAnDataContext db;
        public Librarian() { }
        public Librarian(string nameValue, int numberValue, string addressValue, int idValue) : base(nameValue, numberValue, addressValue, idValue) { }
        public void addBook(Book a)
        {
            db = new database_DoAnDataContext();
            book = new qlyBook();
            try
            {
                book = db.qlyBooks.Where(s => s.BookCode == a.BookCode).Single();
                if (a.Name.CompareTo(book.BookName) == 0 && a.Author.CompareTo(book.Author) == 0
                && a.Date == book.Date)
                {
                    int x = (int)book.Number;
                    x += 1;
                    book.Number = x;
                    db.SubmitChanges();
                    MessageBox.Show("Thong tin sach: \n" + a.bookDetail(), "Them sach thanh cong.");
                }
                else if (a.Name.CompareTo(book.BookName) != 0)
                {
                    MessageBox.Show("Da ton tai ma sach.");
                }
            }
            catch
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

        public void generateReport()
        {
            TextWriter wtr = new StreamWriter("Report.txt");
            wtr.WriteLine("Danh sach sach con lai trong thu vien.");
            wtr.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-10}\n", "Ma sach", "Ten sach", "Tac gia", "Ngay xuat ban", "So sach con lai");
            foreach (qlyBook a in db.qlyBooks)
            {
                DateTime t = (DateTime)a.Date;
                string temp = t.Day + "/" + t.Month + "/" + t.Year;
                wtr.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-10}", a.BookCode, a.BookName, a.Author, temp, a.Number);
            }
            wtr.WriteLine("\n");
            wtr.WriteLine("Danh sach nguoi dung dang muon sach.");
            wtr.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}", "Id", "Name", "Address", "NumberContact", "BookCode", "BookName", "BookNumber");
            foreach (qlyMember a in db.qlyMembers)
            {
                wtr.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}", a.Id, a.Name, a.Address, a.Number, a.BookCode, a.BookName, a.BookNumber);
            }
            wtr.WriteLine("\n");
            wtr.WriteLine("Danh sach nguoi dung da tra sach.");
            wtr.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}", "Id", "Name", "Address", "NumberContact", "BookCode", "BookName", "BookNumber");
            foreach (qlytraSach a in db.qlytraSaches)
            {
                wtr.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}", a.Id, a.Name, a.Address, a.Number, a.BookCode, a.BookName, a.BookNumber);
            }
            wtr.Close();
        }

        public override string printfDetail()
        {

            return "Name: " + Name + " Number contact: " + NumberContact + " Address: " + Address + " ID: " + Id+ "\n";
        }

        public override List<qlyBook> searchBook(string a, string b)
        {
            db = new database_DoAnDataContext();
            int temp = new int();
            try
            {
                temp = int.Parse(a);
            }
            catch
            {
                MessageBox.Show("Moi nhap ma sach la mot so nguyen.");
            }
            var list = (from m in db.qlyBooks where m.BookCode == temp && b.CompareTo(m.Author) == 0 select m).ToList();
            return list;
        }
        public List<qlyBook> searchBook(int temp)
        {
            db = new database_DoAnDataContext();
            var list = (from m in db.qlyBooks where m.BookCode == temp select m).ToList();
            return list;
        }

        public List<qlyBook> searchBook(string b)
        {
            db = new database_DoAnDataContext();
            var list = (from m in db.qlyBooks where b.CompareTo(m.Author) == 0 select m).ToList();
            return list;
        }

        public List<qlyMember> viewMemberDetails()
        {
            db = new database_DoAnDataContext();
            string temp = string.Empty;
            var list = (from a in db.qlyMembers where temp.CompareTo(a.Name) != 0 select a).ToList();
            return list;
        }
    }
}