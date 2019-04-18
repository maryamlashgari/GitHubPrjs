using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasetPajooh
{
    public partial class frmThem : Form
    {
        public frmThem()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThem_Load(object sender, EventArgs e)
        {
            tssDate.Text = DateTime.Now.ToString();
        }
    }
}
