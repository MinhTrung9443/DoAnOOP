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
    public partial class Form1 : Form
    {
        qlyBook sach = new qlyBook();
        qlyMember members = new qlyMember();
        database_DoAnDataContext db = new database_DoAnDataContext();

        public Form1()
        {
            InitializeComponent();
        }

    }
}
