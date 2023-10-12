using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data.OleDb;

namespace pryMoyaIE
{
    internal class clsAccesoDatos
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataAdapter lectorBD;

        string rutaBD;
        DirectoryInfo info = new DirectoryInfo(@"../..");

        public clsAccesoDatos()
        {
            rutaBD = info.FullName + "\\BaseDatos.accdb";

            conexionBD = new OleDbConnection();
            conexionBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaBD;
            conexionBD.Open();
        }

        public void ValidarUsuario(string nombre, string password)
        {
            //buscar con SQL el nombre
        }

        public void RegistrarUsuario(string nombre, string password)
        {
            //insertar con SQL el nombre
        }
    }
}
