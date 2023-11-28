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
    public partial class signUp : Form
    {
        public delegate void truyenDuLieu(string a,string b);
        public truyenDuLieu truyen;
        qlyLogin login;
        database_DoAnDataContext db = new database_DoAnDataContext();
        public signUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = new qlyLogin();
            login.TenDangNhap = tbx_tdn.Text;
            login.Key = tbx_mk.Text;
            login.Id = int.Parse(tbx_id.Text);
            login.Name= tbx_name.Text;
            login.NumberContact = int.Parse(tbx_contact.Text);
            login.Address= tbx_address.Text;
            if (rbtn_lib.Checked == true)
            {
                login.check = 1;
                db.qlyLogins.InsertOnSubmit(login);
                db.SubmitChanges();
                truyen(tbx_tdn.Text, tbx_mk.Text);
            }
            if (rbtn_mem.Checked == true) 
            {
                login.check = 0;
                db.qlyLogins.InsertOnSubmit(login);
                db.SubmitChanges();
                truyen(tbx_tdn.Text, tbx_mk.Text);
            }
   
            Close();
        }
    }
}
