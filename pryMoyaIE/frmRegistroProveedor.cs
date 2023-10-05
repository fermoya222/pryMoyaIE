using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System.IO;

namespace pryMoyaIE
{
    public partial class frmRegistroProveedor : Form
    {
        //LLAMO A LOS OBJ
        clsRegistroProveedores ObjP = new clsRegistroProveedores();
        public frmRegistroProveedor()
        {
            InitializeComponent();
        }

        private void frmRegistroProveedor_Load(object sender, EventArgs e)
        {
            ObjP.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //EVENTO DOBLE CLICK PARA QUE SE AGREGUEN DATOS DE LA GRILLA
        private void dgvProveedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProveedores.Rows[e.RowIndex];

                string numeroRegistro = selectedRow.Cells[0].Value.ToString();
                string entidad = selectedRow.Cells[1].Value.ToString();
                DateTime apertura = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                string numExpediente = selectedRow.Cells[3].Value.ToString();
                string juzgado = selectedRow.Cells[4].Value.ToString();
                string jurisdiccion = selectedRow.Cells[5].Value.ToString();
                string direccion = selectedRow.Cells[6].Value.ToString();
                string responsable = selectedRow.Cells[7].Value.ToString();

                txtNro.Text = numeroRegistro;
                txtEntidad.Text = entidad;
                dtpApertura.Value = apertura;
                dtpApertura.Text = numExpediente;
                cmbJuzg.Text = juzgado;
                cmbJuri.Text = jurisdiccion;
                txtDireccion.Text = direccion;
                cmbLiqui.Text = responsable;

                txtNro.ReadOnly = true;
                btnModificar.Enabled = true;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = true;
            }

            
        }
        //EVENTO PARA HABILITAR BOTON
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtNro.Text != null && txtEntidad.Text != null && dtpApertura.Text != null && txtDireccion.Text != null && cmbLiqui.SelectedIndex != -1 && cmbJuzg.SelectedIndex != -1 && cmbJuri.SelectedIndex != -1)
            {
                btnAgregar.Enabled = true;
            }
        }

        //EVENTO AGREGAR
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNro.Text);
            string entidad = txtEntidad.Text;
            string apertura = dtpApertura.Value.ToShortDateString();
            string expediente = dtpApertura.Text;
            string juzgado = cmbJuzg.Text;
            string juris = cmbJuri.Text;
            string liqui = cmbLiqui.Text;
            string direccion = txtDireccion.Text;


            try
            {
                ObjP.Registrar(numero, entidad, apertura, expediente, juzgado, juris, direccion, liqui);
                limpiarGrilla();
                ObjP.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);
                btnAgregar.Enabled = false;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "", MessageBoxButtons.OK);
            }





        }

        //EVENTO MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNro.Text);
            string entidad = txtEntidad.Text;
            string apertura = dtpApertura.Value.ToShortDateString();
            string expediente = dtpApertura.Text;
            string juzgado = cmbJuzg.Text;
            string juris = cmbJuri.Text;
            string liqui = cmbLiqui.Text;
            string direccion = txtDireccion.Text;


            try
            {
                ObjP.Modificar(numero, entidad, apertura, expediente, juzgado, juris, direccion, liqui);
                limpiarGrilla();
                ObjP.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);
                btnAgregar.Enabled = false;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "", MessageBoxButtons.OK);
            }
        }


        //EVENTO ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Estás seguro de que deseas eliminar?", "Confirmación", MessageBoxButtons.YesNo);
            int numero = Convert.ToInt32(txtNro.Text);

            if (pregunta == DialogResult.Yes)
            {
                ObjP.Eliminar(numero);
                limpiarGrilla();
                ObjP.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);
                Limpiar();
            }
        }

        //LIMPIAR TXT Y CMB
        private void Limpiar()
        {
            txtDireccion.Text = "";
            txtEntidad.Text = "";
            dtpApertura.Text = "";
            txtNro.Text = "";
            cmbJuri.SelectedIndex = -1;
            cmbJuzg.SelectedIndex = -1;
            cmbLiqui.SelectedIndex = -1;
        }

        //limpiar grilla
        private void limpiarGrilla()
        {
            dgvProveedores.Rows.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtNro_TextChanged(object sender, EventArgs e)
        {
            if (txtNro.Text != null)
            {
                btnLimpiar.Enabled = true;
            }
        }
    }
}

