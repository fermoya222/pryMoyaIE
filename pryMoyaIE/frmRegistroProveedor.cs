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
    public partial class frmRegistroProveedor : Form
    {
        public frmRegistroProveedor()
        {
            InitializeComponent();
        }

        private void frmRegistroProveedor_Load(object sender, EventArgs e)
        {
            //traer todos los proveedores registrados
            StreamReader lectorArchivo = new StreamReader("listadoProveedores.csv");

            //grillaProveedores.Columns.Add("1", "titulo");

            bool eslaprimerafila = true; //primera fila

            string leerElrenglon="";
            string[] separarDatos;

            while (!lectorArchivo.EndOfStream)
            {
                leerElrenglon = lectorArchivo.ReadLine();
                separarDatos = leerElrenglon.Split(';');
                if (eslaprimerafila==true)
                {
                    //crear las columans de la grilla con los datos de la primer fila

                    for (int indice = 0; indice < separarDatos.Length; indice++)
                    {
                        grillaProveedores.Columns.Add(separarDatos[indice], separarDatos[indice]);
                    }                    

                    eslaprimerafila = false;
                }
                else 
                {
                    grillaProveedores.Rows.Add(separarDatos);
                }                

                //
            }

            lectorArchivo.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
