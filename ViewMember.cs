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

    }
}
