using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMoyaIE
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //registro
            StreamWriter sw = new StreamWriter("logInicio", false);
            sw.WriteLine(textBox1.Text + " - Fecha: " + DateTime.Now);
            sw.Close();


            this.Hide();
            frmMain v = new frmMain();
            v.ShowDialog();
        }
    }
}
