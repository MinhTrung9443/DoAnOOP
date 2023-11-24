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
    public partial class ViewMember : Form
    {
        qlyMember mb;
        database_DoAnDataContext db = new database_DoAnDataContext();
        public ViewMember()
        {
            InitializeComponent();
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'do_an_oopDataSet1.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.do_an_oopDataSet1.Member);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                var list = (from a in db.qlyMembers select a).ToList();
                dataGridView1.DataSource = list;
            }
            else
            {
                int t = 0;
                try
                {
                    t = int.Parse(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Moi nhap vao id la mot so nguyen.");
                    textBox1.Text = "";
                    var l = (from a in db.qlyMembers select a).ToList();
                    dataGridView1.DataSource = l;
                }
                var list = (from a in db.qlyMembers where a.Id == t select a).ToList();
                dataGridView1.DataSource = list;
            }
        }
    }
}
