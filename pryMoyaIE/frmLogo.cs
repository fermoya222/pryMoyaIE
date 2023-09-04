using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMoyaIE
{
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        private void frmLogo_Load(object sender, EventArgs e)
        {

        }
        int contadorTiempo = 0;

        private void temporizador_Tick(object sender, EventArgs e)
        {
            contadorTiempo += 1000;
            if(contadorTiempo > 3000)
            {
                this.Hide();
                frmRegistro formularioPrincipal = new frmRegistro();
                formularioPrincipal.Show();
                temporizador.Enabled = false;
            }
;
        }
    }
}
