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
    public partial class NguoiDung : Form
    {
        public delegate void chuyen(int a);
        public chuyen truyen;

        Member mem = new Member();
        database_DoAnDataContext db;
        public NguoiDung(Member x)
        {
            InitializeComponent();
            this.bookTableAdapter.Fill(this.do_an_oopDataSet.Book);
            mem = x;
            lbl_ten.Text = mem.Name;
            lbl_id.Text = mem.Id.ToString();
            lbl_contact.Text = mem.NumberContact.ToString();
            lbl_address.Text = mem.Address;
        }
        private void NguoiDung_Load(object sender, EventArgs e)
        {
            db = new database_DoAnDataContext();
            var l = (from a in db.qlyBooks select a).ToList();
            dataGridView1.DataSource = l;
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (truyen!= null)
            {
                truyen(1);
            }
            Close();
        }
        private void traSach(string a, string b, object sender, EventArgs e)
        {
            mem.returnBook(a, b, mem);
            NguoiDung_Load(sender, e);
        }
        private void btn_return_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            NhapTT a = new NhapTT();
            NguoiDung_Load(sender, e);
            a.truyen = new NhapTT.truyenDuLieu(traSach);
            a.Show();
        }

        private void search1(string a, string b)
        {
            var list = mem.searchBook(a, b);
            if (list.Count > 0)
            {
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("Khong tim thay trong thu vien.");
                return;
            }
            label1.Visible = true;
        }
        private void search1(int a)
        {
            var list = mem.searchBook(a);
            if (list.Count > 0)
            {
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("Khong tim thay trong thu vien.");
                return;
            }
            
        }
        private void search1(string a)
        {
            var list = mem.searchBook(a);
            if (list.Count > 0)
            {
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("Khong tim thay trong thu vien.");
                return;
            }
        }
        private void btn_search_member_Click(object sender, EventArgs e)
        {
            Search a = new Search();
            a.chuyen1 = new Search.truyen1(search1);
            a.chuyen2 = new Search.truyen2(search1);
            a.chuyen3 = new Search.truyen3(search1);
            a.Show();
        }
        private void muonSach(string a, string b, object sender, EventArgs e)
        {
            mem.issueBook(a, b, mem);
            NguoiDung_Load(sender, e);
        }
        private void btn_issue_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            NguoiDung_Load(sender, e);
            NhapTT a = new NhapTT();
            a.truyen = new NhapTT.truyenDuLieu(muonSach);
            a.Show();
        }
    }
}
