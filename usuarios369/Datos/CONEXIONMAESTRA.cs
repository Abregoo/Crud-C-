using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace usuarios369.Datos
{
    internal static class  CONEXIONMAESTRA
    {
        public static SqlConnection conexion = new SqlConnection(@"Data source=DESKTOP-448JONO\SQLEXPRESS; Initial Catalog=USUARIOSDB; Integrated Security=true");
        public static void abrir()
        {
            if (conexion.State == ConnectionState.Closed )
            {
                conexion.Open();

            }

           
        }
        public static void cerrar()
        {
            if (conexion.State == ConnectionState.Open )
            {
                conexion.Close();
            }
        }
    }
}
