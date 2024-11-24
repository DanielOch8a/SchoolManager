using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolManager
{
    class CConexionBD
    {
        
        public void Instruccion(string cadenaSQL)
        {
            //Conexion Laptop
            string cadenaConexion = @"Data Source=THEMONSTER\MSSQLSERVER_DEV;Initial Catalog=BD_SM_ADMIN_sqlServer;Integrated Security=True";
            SqlConnection conectar = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
            conectar.Dispose();
            comando.Dispose();
        }

        public DataTable ConsultaTabla(string cadenaSQL)
        {
            string cadenaConexion = @"Data Source=THEMONSTER\MSSQLSERVER_DEV;Initial Catalog=BD_SM_ADMIN_sqlServer;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection conectar = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            da.SelectCommand = comando;
            conectar.Open();
            da.Fill(dt);
            conectar.Close();
            conectar.Dispose();
            comando.Dispose();
            da.Dispose();
            return dt;
        }



    }
}
