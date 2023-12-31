﻿using System;
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
    public partial class Thong_tin : Form
    {
        public delegate void truyenDuLieu(string a, string b, string c, string d);
        public truyenDuLieu truyen;
        public Thong_tin()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int temp = 0;
            Member a = new Member();
            a.Name = tbx_name.Text;
            a.Address = tbx_address.Text;
            try
            {
                a.Id = int.Parse(tbx_id.Text);
            }
            catch
            {
                temp = 1;
                MessageBox.Show("Moi nhap vao Id mot so nguyen.");
            }
            try
            {
                a.NumberContact =  int.Parse(tbx_contact.Text);
            }
            catch
            {
                temp = 1;
                MessageBox.Show("Moi nhap vao NumberContact mot so nguyen.");
            }
            if (truyen != null && temp == 0)
            {
                truyen(tbx_name.Text,tbx_id.Text,tbx_contact.Text,tbx_address.Text);
            }
            Close();
        }

    }
}
