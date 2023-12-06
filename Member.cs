using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace DoAnOOP
{
    public class Member : Person, IMember
    {
        qlyMember member;
        qlyBook book;
        database_DoAnDataContext db;
        public Member() { }
        public Member(string nameValue,int numberValue, string addressValue, int idValue) : base (nameValue,numberValue,addressValue,idValue) { }
        public void issueBook(string a,string b, Member mem)
        {
            db = new database_DoAnDataContext();
            book = new qlyBook();
            int x = new int();
            try
            {
                x = int.Parse(a);
            }
            catch
            {
                MessageBox.Show("Moi nhap Id la mot so nguyen");
                return;
            }
           
            try
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
                    try
                    {
                        member = db.qlyMembers.Where(k => k.Id == mem.Id && k.BookCode == x).First();
                        int temp = (int)member.BookNumber;
                        member.BookNumber = temp + 1;
                        db.SubmitChanges();
                        MessageBox.Show("Da muon sach xong");
                        return;
                    }
                    catch
                    {
                        member.Name = mem.Name;
                        member.Address = mem.Address;
                        member.Id = mem.Id;
                        member.Number = mem.NumberContact;
                        member.BookCode = book.BookCode;
                        member.BookName = book.BookName;
                        member.BookNumber = 1;
                        member.stt = (int)db.qlyMembers.Max(k => k.stt) + 1;
                        member.stt = (int)member.stt;
                        db.qlyMembers.InsertOnSubmit(member);
                        db.SubmitChanges();
                        MessageBox.Show("Da muon sach xong");
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Khong ton tai sach trong thu vien");
            }
        }

        public override string printfDetail()
        {
            return "Id: " + Id + " Name: " + Name + " Address: " + Address + " Number: " + NumberContact;
        }

        public void returnBook(string a, string b, Member mem)
        {
            db = new database_DoAnDataContext();
            int x = new int();
            try
            {
                x = int.Parse(a);
            }
            catch
            {
                MessageBox.Show("Moi nhap Id la mot so nguyen");
                return;
            }
            book = new qlyBook();
            member = new qlyMember();
            try
            {
                book = db.qlyBooks.Where(s => s.BookCode == x && b.CompareTo(s.BookName) == 0).First();
                int temp = (int)book.Number;
                book.Number = temp + 1;

                try
                {
                    member = db.qlyMembers.Where(s => (int)s.BookCode == x && mem.Name.CompareTo(s.Name) ==0).First();
                    qlytraSach sachtra = new qlytraSach();
                    try
                    {
                        sachtra = db.qlytraSaches.Where(s => s.Id == mem.Id && (int)s.BookCode == x).First();
                        int m = (int)sachtra.BookNumber;
                        sachtra.BookNumber = m + 1;

                    }
                    catch
                    {
                        sachtra.Id = member.Id;
                        sachtra.Name = member.Name;
                        sachtra.Number = member.Number;
                        sachtra.Address = member.Address;
                        sachtra.BookCode = member.BookCode;
                        sachtra.BookName = member.BookName;
                        sachtra.BookNumber = 1;
                        sachtra.stt = (int)db.qlytraSaches.Max(s => s.stt) + 1;
                        db.qlytraSaches.InsertOnSubmit(sachtra);
                    }

                    int ta = (int)member.BookNumber;
                    if (ta > 1)
                    {
                        member.BookNumber = ta - 1;
                    }
                    else
                    {
                        db.qlyMembers.DeleteOnSubmit(member);
                    }
                    db.SubmitChanges();
                    MessageBox.Show("Da tra sach xong");
                }
                catch
                {
                    MessageBox.Show("Ban chua muon sach nay.");
                }
            }
            catch
            {
                MessageBox.Show("Khong tra sach duoc");
            }
        }

        public override List<qlyBook> searchBook(string a, string b)
        {
            db = new database_DoAnDataContext();
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
            var list = (from m in db.qlyBooks where m.BookCode == temp && b.CompareTo(m.Author) == 0 select m).ToList();
            return list;
        }
        public List<qlyBook> searchBook(int temp)
        {
            db = new database_DoAnDataContext();
            Librarian x = new Librarian();
            var list = (from m in db.qlyBooks where m.BookCode == temp select m).ToList();
            return list;
        }

        public List<qlyBook> searchBook(string b)
        {
            db = new database_DoAnDataContext();
            Librarian x = new Librarian();
            var list = (from m in db.qlyBooks where b.CompareTo(m.Author) == 0 select m).ToList();
            return list;
        }
    }
}