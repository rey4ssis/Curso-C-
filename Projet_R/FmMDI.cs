using Projet_R.forma1;
using Projet_R.forma2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_R
{
    public partial class FmMDI : Form
    {
        public FmMDI()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void forma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm1_formulario1 fm = new fm1_formulario1();
        }
    }
}
