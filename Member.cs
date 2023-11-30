﻿using System;
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
        database_DoAnDataContext db = new database_DoAnDataContext();
        public Member() { }
        public Member(string nameValue,int numberValue, string addressValue, int idValue) : base (nameValue,numberValue,addressValue,idValue) { }
        public void issueBook(string a,string b, Member mem)
        {
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
                        member.BookNumber = temp + 1;
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
                        member.stt = (int)member.stt;
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

        public override string printfDetail()
        {
            return "Id: " + Id + " Name: " + Name + " Address: " + Address + " Number: " + NumberContact;
        }

        public void returnBook(string a, string b, Member mem)
        {
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
            var list = (from k in db.qlyMembers where k.BookCode == x && k.BookName.CompareTo(b) == 0 && mem.Name.CompareTo(k.Name) == 0 select k).ToList();
            if (list.Count > 0)
            {
                book = db.qlyBooks.Where(s => s.BookCode == x && b.CompareTo(s.BookName) == 0).First();
                int temp = (int)book.Number;
                book.Number = temp + 1;
                member = db.qlyMembers.Where(s => s.BookCode == x).First();
                addTraSach(member);
                if ((int)member.Number > 1)
                {
                    int ta = (int)member.BookNumber;
                    member.BookNumber = ta - 1;
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
        private void addTraSach(qlyMember a)
        {
            qlytraSach sachtra = new qlytraSach();
            var l = (from s in db.qlytraSaches where s.Id == a.Id && s.BookCode == a.BookCode select s).ToList();
            if (l.Count == 0)
            {
                sachtra.Id = a.Id;
                sachtra.Name = a.Name;
                sachtra.Number = a.Number;
                sachtra.Address = a.Address;
                sachtra.BookCode = a.BookCode;
                sachtra.BookName = a.BookName;
                sachtra.BookNumber = 1;
                sachtra.stt = (int)db.qlytraSaches.Max(s => s.stt) + 1;
                db.qlytraSaches.InsertOnSubmit(sachtra);
            }
            else
            {
                sachtra = db.qlytraSaches.Where(s => s.Id == a.Id && s.BookCode == a.BookCode).First();
                int temp = (int)sachtra.BookNumber;
                sachtra.BookNumber = temp + 1;
            }
            db.SubmitChanges();
        }
        public override List<qlyBook> searchBook(string a, string b)
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
    }
}