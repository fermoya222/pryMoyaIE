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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(object objUsuario)
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Fecha.Text=DateTime.Now.ToLongDateString();
            Hora.Text=DateTime.Now.ToLongTimeString();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //registro
            StreamWriter sw = new StreamWriter("logGeneral", false);
            sw.WriteLine( " - Fecha: " + DateTime.Now);
            sw.Close();

            frmRegistroProveedor v = new frmRegistroProveedor();
            v.ShowDialog();
        }
        
       
        private void timer1_Tick(object sender, EventArgs e)
        {
               Hora.Text=Convert.ToString(DateTime.Now);
         
       

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivos v = new frmArchivos();
            v.ShowDialog();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
