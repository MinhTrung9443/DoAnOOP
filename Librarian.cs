using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
namespace DoAnOOP
{
    public class Librarian : Person, ILibrarian
    {
        qlyBook book;
        database_DoAnDataContext db = new database_DoAnDataContext();
        public Librarian() { }
        public Librarian(string nameValue, int numberValue, string addressValue, int idValue) : base(nameValue, numberValue, addressValue, idValue) { }
        public void addBook(Book a)
        {
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

        public string generateReport()
        {
            return "'";
        }

        public override string printfDetail()
        {

            return "Name: " + Name + " Number contact: " + NumberContact + " Address: " + Address + " ID: " + Id+ "\n";
        }

        public override List<qlyBook> searchBook(string a,string b)
        {
            int temp = new int();
            Librarian x = new Librarian();
            try
            {
                temp = int.Parse(a);
            }
            catch
            {
                MessageBox.Show("Moi nhap ma sach la mot so nguyen.");
            }
            var list = (from m in db.qlyBooks where m.BookCode == temp && m.BookName.CompareTo(b) == 0 select m).ToList();
            return list;
        }

        public List<qlyMember> viewMemberDetails()
        {
            string temp = string.Empty;
            var list = (from a in db.qlyMembers where temp.CompareTo(a.Name) != 0 select a).ToList();
            return list;
        }
    }
}