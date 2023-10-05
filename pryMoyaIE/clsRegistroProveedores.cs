using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryMoyaIE
{
    internal class clsRegistroProveedores
    {

        //LEER ARCHIVO CSV
        public void CargarInfo(DataGridView grilla, ComboBox cmbJuzg, ComboBox cmbJuri, ComboBox cmbLiqui)
        {

            DirectoryInfo info = new DirectoryInfo(@"..\..");

            string archivoProveedor = info.FullName + "\\Listado de aseguradores.csv";

            try
            {

                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        string[] separador = readLine.Split(';');


                        HashSet<string> jurisdicciones = new HashSet<string>();
                        HashSet<string> responsables = new HashSet<string>();
                        HashSet<string> juzgados = new HashSet<string>();

                        while (!sr.EndOfStream)
                        {
                            readLine = sr.ReadLine();
                            separador = readLine.Split(';');
                            grilla.Rows.Add(separador);

                            juzgados.Add(separador[4]);
                            jurisdicciones.Add(separador[5]);
                            responsables.Add(separador[7]);

                        }

                        foreach (string jurisdiccion in jurisdicciones)
                        {
                            cmbJuri.Items.Add(jurisdiccion);
                        }

                        foreach (string juzgado in juzgados)
                        {
                            cmbJuzg.Items.Add(juzgado);
                        }

                        foreach (string liquida in responsables)
                        {
                            cmbLiqui.Items.Add(liquida);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }


        //NUEVO REGISTRO EN ARCHIVO CSV
        public void Registrar(int id, string entidad, string Apertura, string expendiente, string juzg, string juri, string direccion, string liquidador)
        {
            string archivoProveedor = "Listado de aseguradores.csv";

            try
            {
                List<int> idsExistentes = new List<int>();

                // Leer las IDs existentes sin sobrescribir el archivo
                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine;
                    while ((readLine = sr.ReadLine()) != null)
                    {
                        string[] separador = readLine.Split(';');

                        if (separador.Length >= 1 && int.TryParse(separador[0], out int existingID))
                        {
                            idsExistentes.Add(existingID);
                        }
                    }
                }

                if (!idsExistentes.Contains(id))
                {
                    string nuevoRegistro = $"{id};{entidad};{Apertura};{expendiente};{juzg};{juri};{direccion};{liquidador};";

                    // Abrir el archivo en modo de escritura con la opción true para agregar nuevos registros
                    using (StreamWriter sw = new StreamWriter(archivoProveedor, true))
                    {
                        sw.WriteLine(nuevoRegistro);
                    }

                    MessageBox.Show("Registro agregado correctamente.", "Éxito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El ID ya existe en el archivo.", "ERROR", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        //MODIFICAR ARCHIVO CSV
        public void Modificar(int id, string entidad, string Apertura, string expendiente, string juzg, string juri, string direccion, string liquidador)
        {
            string archivoProveedor = "Listado de aseguradores.csv";

            try
            {
                List<string> lineas = new List<string>();
                bool primerLinea = true;

                using (StreamReader lector = new StreamReader(archivoProveedor))
                {
                    string readLine;
                    while ((readLine = lector.ReadLine()) != null)
                    {
                        string[] separador = readLine.Split(';');

                        if (separador.Length > 0 && int.TryParse(separador[0], out int existingID))
                        {
                            if (existingID == id)
                            {
                                string nuevaLinea = $"{id};{entidad};{Apertura};{expendiente};{juzg};{juri};{direccion};{liquidador}";
                                lineas.Add(nuevaLinea);
                            }
                            else
                            {
                                lineas.Add(readLine);
                            }
                        }
                    }
                }

                // Escribe las líneas en el archivo original
                using (StreamWriter sw = new StreamWriter(archivoProveedor, false))
                {
                    foreach (string linea in lineas)
                    {
                        // Agregar la primera línea con los títulos de las columnas
                        if (primerLinea)
                        {
                            sw.WriteLine(linea);
                            primerLinea = false;
                        }
                        else
                        {
                            sw.WriteLine(linea);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //ELIMINAR REGISTRO EN CSV
        public void Eliminar(Int32 id)
        {
            string archivoProveedor = "Listado de aseguradores.csv";
            List<string> lineas = new List<string>();

            try
            {
                // Leer todas las líneas del archivo y guardarlas en una lista
                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine;
                    while ((readLine = sr.ReadLine()) != null)
                    {
                        string[] separador = readLine.Split(';');

                        if (separador.Length >= 1 && int.TryParse(separador[0], out int existingID))
                        {
                            // Si el ID coincide con el que deseamos eliminar, no lo agregamos a la lista
                            if (existingID != id)
                            {
                                lineas.Add(readLine);
                            }
                        }
                    }
                }

                // Sobreescribir el archivo con las líneas actualizadas
                using (StreamWriter sw = new StreamWriter(archivoProveedor, false))
                {
                    foreach (string linea in lineas)
                    {
                        sw.WriteLine(linea);
                    }
                }

                MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

    }
}

