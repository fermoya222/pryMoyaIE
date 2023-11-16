using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace pryMoyaIE
{
    public partial class frmNuevoUsuario : Form
    {
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void lblFirma_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string NuevoUsuario = txtUsuario.Text;
            string NuevaContraseña = txtPassword.Text;
            string Rol = cboRol.Text;

            clsUsuario objUsuario = new clsUsuario();
            objUsuario.RegistrarLogs(NuevoUsuario, NuevaContraseña, Rol);
            frmRegistro Inicio = new frmRegistro();
            Inicio.ShowDialog();
            this.Hide();
        }

        private byte[] ConvertPictureBoxToBytes(PictureBox pictureBox)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Convierte la imagen en el PictureBox en un formato de imagen
                pictureBox.Image.Save(memoryStream, ImageFormat.Png);

                // Obtiene los bytes de la imagen
                return memoryStream.ToArray();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                cboRol.Enabled = true;
            }
            else
            {
                cboRol.Enabled = false;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRol.SelectedIndex != -1)
            {
                txtPassword.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;
            }
        }

       
    }
}
