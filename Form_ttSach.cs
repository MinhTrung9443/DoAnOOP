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
    public partial class Form_ttSach : Form
    {
        public delegate void truyenDuLieu(Book a, object sender, EventArgs e);
        public truyenDuLieu truyen;
        public Form_ttSach()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int temp = 0;
           Book a = new Book();
            a.Name = tbx_name.Text;
            a.Author= tbx_author.Text;
            try
            {
                a.BookCode = int.Parse(tbx_code.Text);
            }
            catch
            {
                temp = 1;
                MessageBox.Show("Moi nhap vao ma sach mot so nguyen.");
            }
            try
            {
                a.Date = DateTime.Parse(tbx_date.Text);
            }
            catch
            {
                temp = 1;
                MessageBox.Show("Moi nhap vao Ngay san xuat theo dinh dang sau m/d/y.");
            }
            if (truyen != null && temp == 0)
            {
                truyen(a,sender,e);
            }
            Close();
        }
    }
}
