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
        qlyBook book = new qlyBook();
        qlyMember member = new qlyMember();
        database_DoAnDataContext db = new database_DoAnDataContext();
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();
        public Form1()
        {
            InitializeComponent();
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
            this.bookTableAdapter.Fill(this.do_an_oopDataSet.Book);
        }
    }
}
