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
    public partial class Form2 : Form
    {
        public delegate void truyenDuLieu(Book a, object sender, EventArgs e);
        public truyenDuLieu truyen;
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
           Book a = new Book();
            a.Name = tbx_name.Text;
            a.Author= tbx_author.Text;
            a.Date = DateTime.Parse(tbx_date.Text);
            a.BookCode = int.Parse(tbx_code.Text);
            if (truyen != null)
            {
                truyen(a,sender,e);
            }
            Close();
        }
    }
}
