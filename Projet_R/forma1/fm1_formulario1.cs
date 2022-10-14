using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_R.forma1
{
    public partial class fm1_formulario1 : Form
    {
        public fm1_formulario1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            fm1_formulario2 frm = new fm1_formulario2();
            frm.Show();
        }
    }
}
