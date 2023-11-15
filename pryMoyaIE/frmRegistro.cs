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
        

        public void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtPassword.Text;
            // Se obtienen el nombre de usuario y la contraseña de los campos de entrada en el formulario.

            clsUsuario objUsuario = clsUsuario.Login(usuario, contraseña);
            // Se crea una instancia de la clase clsLogs y se llama al método Login para intentar autenticar al usuario.

           
            
        }   

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario Nuevo = new frmNuevoUsuario();
            Nuevo.ShowDialog();
            this.Hide();
        }
    }
}
