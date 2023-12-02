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
    public partial class report : Form
    {

        database_DoAnDataContext db = new database_DoAnDataContext();
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'do_an_oopDataSet1.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.do_an_oopDataSet1.Member);
            string temp = string.Empty;
            var l = (from a in db.qlytraSaches where temp.CompareTo(a.Name) != 0 select a).ToList();
            grid_tra.DataSource= l;
        }

        private void report1_Click(object sender, EventArgs e)
        {
            TextWriter wtr = new StreamWriter("Report1.txt");
            wtr.WriteLine("Id \t Name  \t\t\t Address \t NumberContact \t BookCode \t BookName \t BookNumber \n");
            foreach (qlyMember a in db.qlyMembers)
            {
                wtr.WriteLine(a.Id + "\t" + a.Name + "\t\t" + a.Address + "\t\t" + a.Number + "\t" + a.BookCode + "\t" + a.BookName + "\t" + a.BookNumber);
            }
            wtr.Close();
        }

        private void report2_Click(object sender, EventArgs e)
        {
            TextWriter wtr = new StreamWriter("Report2.txt");
            wtr.WriteLine("Id \t Name  \t\t\t Address \t NumberContact \t BookCode \t BookName \t BookNumber \n");
            foreach (qlytraSach a in db.qlytraSaches)
            {
                wtr.WriteLine(a.Id + "\t" + a.Name + "\t\t" + a.Address + "\t\t" + a.Number + "\t" + a.BookCode + "\t" + a.BookName + "\t" + a.BookNumber);
            }
            wtr.Close();
        }

        private void report3_Click(object sender, EventArgs e)
        {
            TextWriter wtr = new StreamWriter("Report.txt");
            wtr.WriteLine("Danh sach sach con lai trong thu vien.");
            foreach(qlyBook a in db.qlyBooks)
            {
                wtr.WriteLine(a.BookCode + "" + a.BookName + " " + a.Author + "" + a.Date.ToString());
            }
            wtr.WriteLine("\n");
            wtr.WriteLine("Danh sach nguoi dung dang muon sach.");
            wtr.WriteLine("Id \t Name  \t\t\t Address \t NumberContact \t BookCode \t BookName \t BookNumber \n");
            foreach (qlyMember a in db.qlyMembers)
            {
                wtr.WriteLine(a.Id + "\t" + a.Name + "\t\t" + a.Address + "\t\t" + a.Number + "\t" + a.BookCode + "\t" + a.BookName + "\t" + a.BookNumber);
            }
            wtr.WriteLine("\n");
            wtr.WriteLine("Danh sach nguoi dung da tra sach.");
            wtr.WriteLine("Id \t Name  \t\t\t Address \t NumberContact \t BookCode \t BookName \t BookNumber \n");
            foreach (qlytraSach a in db.qlytraSaches)
            {
                wtr.WriteLine(a.Id + "\t" + a.Name + "\t\t" + a.Address + "\t\t" + a.Number + "\t" + a.BookCode + "\t" + a.BookName + "\t" + a.BookNumber);
            }
            wtr.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
