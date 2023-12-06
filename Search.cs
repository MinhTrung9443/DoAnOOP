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
    public partial class Search : Form
    {
        public delegate void truyen1(string a, string b);
        public delegate void truyen2(int a);
        public delegate void truyen3(string b);
        public truyen1 chuyen1;
        public truyen2 chuyen2;
        public truyen3 chuyen3;
        public Search()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int temp = new int();
            if (tbx_bookcode.Text.Length > 0 )
            {
                try
                {
                    temp = int.Parse(tbx_bookcode.Text);
                }
                catch
                {
                    MessageBox.Show("Moi nhap ma sach la 1 so nguyen.");
                }
            }

            if (checkMa.Checked == true && checkAu.Checked == true) {
                if (chuyen1 != null) {
                    chuyen1(tbx_bookcode.Text, tbx_bookName.Text);
                }

            }
            else if (checkMa.Checked == true && checkAu.Checked == false)
            {
                if (chuyen2 != null)
                {
                    chuyen2(temp);
                }
            }
            else if (checkMa.Checked == false && checkAu.Checked == true)
            {
                if (chuyen3 != null)
                {
                    chuyen3(tbx_bookName.Text);
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
