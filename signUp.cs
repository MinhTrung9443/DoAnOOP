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
            if (lbl_bao.Visible == true)
            {
                MessageBox.Show("Thong tin khong hop le.");
                return;
            }
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

        private void tbx_tdn_TextChanged(object sender, EventArgs e)
        {
            if (tbx_tdn.Text != "")
            {
                var l = (from a in db.qlyLogins where tbx_tdn.Text.CompareTo(a.TenDangNhap) == 0 select a).ToList();
                if (l.Count > 0)
                {
                    lbl_bao.Text = "Da ton tai ten dang nhap. Moi nhap ten khac.";
                    lbl_bao.Visible = true;
                }
                else
                {
                    lbl_bao.Visible = false;
                }
            }
        }

        private void tbx_id_TextChanged(object sender, EventArgs e)
        {
            if (tbx_id.Text != "")
            try
            {
                int a = int.Parse(tbx_id.Text);
            }
            catch
            {
                MessageBox.Show("Moi dien id la so.");
                tbx_id.Text = string.Empty;
                return;
            }
        }

        private void tbx_contact_TextChanged(object sender, EventArgs e)
        {
            if (tbx_contact.Text != "")
            try
            {
                int a = int.Parse(tbx_contact.Text);
            }
            catch
            {
                MessageBox.Show("Moi dien so lien lac la so.");
                tbx_contact.Text = string.Empty;
                return;
            }
        }

        private void lbl_bao_Click(object sender, EventArgs e)
        {

        }
    }
}
