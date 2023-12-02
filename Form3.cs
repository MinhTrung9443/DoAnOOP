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
    public partial class Form3 : Form
    {
        public delegate void truyenDuLieu(string a,string b);
        public truyenDuLieu truyen;
        public Form3()
        {
            InitializeComponent();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (truyen != null)
            {
                truyen(tbx_bookcode.Text,tbx_bookName.Text);
            }
            Close();
        }
    }
}
