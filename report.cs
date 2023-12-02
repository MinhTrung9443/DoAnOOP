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
            Librarian lbr = new Librarian();
            grid_muon.DataSource = lbr.viewMemberDetails();
            string temp = string.Empty;
            var l = (from a in db.qlytraSaches where temp.CompareTo(a.Name) != 0 select a).ToList();
            grid_tra.DataSource= l;
        }

        private void report1_Click(object sender, EventArgs e)
        {
            TextWriter wtr = new StreamWriter("Report1.txt");
            wtr.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}","Id","Name","Address","NumberContact","BookCode","BookName","BookNumber");
            foreach (qlyMember a in db.qlyMembers)
            {
                wtr.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}",a.Id,a.Name,a.Address,a.Number,a.BookCode,a.BookName,a.BookNumber);
            }
            wtr.Close();
        }

        private void report2_Click(object sender, EventArgs e)
        {
            TextWriter wtr = new StreamWriter("Report2.txt");
            wtr.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}\n", "Id", "Name", "Address", "NumberContact", "BookCode", "BookName", "BookNumber");
            foreach (qlytraSach a in db.qlytraSaches)
            {
                wtr.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}", a.Id, a.Name, a.Address, a.Number, a.BookCode, a.BookName, a.BookNumber);
            }
            wtr.Close();
        }

        private void report3_Click(object sender, EventArgs e)
        {
            TextWriter wtr = new StreamWriter("Report.txt");
            wtr.WriteLine("Danh sach sach con lai trong thu vien.");
            wtr.WriteLine("{0,-10} {1,-20} {2,-20} {3,-10}", "Ma sach", "Ten sach", "Tac gia", "Ngay xuat ban");
            foreach(qlyBook a in db.qlyBooks)
            {   
                DateTime t = (DateTime)a.Date;
                string temp = t.Day +"/"+t.Month+"/"+t.Year;    
                wtr.WriteLine("{0,-10} {1,-20} {2,-20} {3,-10}",a.BookCode,a.BookName,a.Author,temp);
            }
            wtr.WriteLine("\n");
            wtr.WriteLine("Danh sach nguoi dung dang muon sach.");
            wtr.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}", "Id", "Name", "Address", "NumberContact", "BookCode", "BookName", "BookNumber");
            foreach (qlyMember a in db.qlyMembers)
            {
                wtr.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}", a.Id, a.Name, a.Address, a.Number, a.BookCode, a.BookName, a.BookNumber);
            }
            wtr.WriteLine("\n");
            wtr.WriteLine("Danh sach nguoi dung da tra sach.");
            wtr.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}", "Id", "Name", "Address", "NumberContact", "BookCode", "BookName", "BookNumber");
            foreach (qlytraSach a in db.qlytraSaches)
            {
                wtr.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-10} {5,-20} {6,-10}", a.Id, a.Name, a.Address, a.Number, a.BookCode, a.BookName, a.BookNumber);
            }
            wtr.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
