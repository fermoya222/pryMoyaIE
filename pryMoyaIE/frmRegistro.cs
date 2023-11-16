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
        int intentos = 0;
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

            if (objUsuario != null)
            {
                // Si el objeto de usuario no es nulo, significa que la autenticación fue exitosa.
                clsUsuario.RegistrarLog(usuario);
                // Se registra un log de inicio de sesión.
                this.Hide();
                // Se oculta el formulario actual.
                frmMain forMain = new frmMain(objUsuario);
                // Se crea una nueva instancia del formulario frmMain pasando el objeto de usuario autenticado.
                forMain.ShowDialog();
                // Se muestra el formulario frmMain en modo de diálogo.
            }
            else
            {
                // Si el objeto de usuario es nulo, la autenticación falló.
                MessageBox.Show("Usuario o contraseña incorrectos." + MessageBoxButtons.OK + MessageBoxIcon.Error);
                intentos++;
                // Se incrementa el contador de intentos.
                MessageBox.Show(intentos + " de 3 intentos");
                // Se muestra la cantidad de intentos restantes.
                txtPassword.Text = "";
                txtUsuario.Text = "";
                // Se limpian los campos de entrada.

                if (intentos >= 3)
                {
                    // Si se supera el límite de 3 intentos.
                    MessageBox.Show("Limite de intentos alcanzado, Tiempo de espera " + (Timer.Interval / 1000) + " segundos" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                    // Se muestra un mensaje de advertencia con el tiempo de espera.
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    btnIniciarSesion.Enabled = false;
                    // Se deshabilitan los campos de entrada y el botón de inicio de sesión.

                    Timer.Tick += contador_Tick;
                    Timer.Start();


                }
            }

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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        public void ValidarDatos()
        {
            if (txtUsuario.Text != "" && txtPassword.Text != "")
            {
                btnIniciarSesion.Enabled = true;
            }
            else
            {
                btnIniciarSesion.Enabled = false;
            }
        }

        private void contador_Tick(object sender, EventArgs e)
        {
            // Habilitar el botón y detener el temporizador.
            intentos = 0;
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            btnIniciarSesion.Enabled = true;
            Timer.Stop();
        }
    }
}
