using System;
using System.Data.SqlClient;

namespace Data
{
    class connection
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static connection conn = null;

        private connection()
        {
            this.Base = "CrudDB";
            this.Servidor = "JOHANA\\SQLEXPRESS";
            this.Usuario = "Johana";
            this.Clave = "";
            this.Seguridad = true;
        }

        public SqlConnection createConnection()
        {
            SqlConnection chain = new SqlConnection();
            try
            {
                chain.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if(this.Seguridad)
                {
                    chain.ConnectionString = chain.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    chain.ConnectionString = chain.ConnectionString + "User " + this.Usuario + ";Password=" + this.Clave;
                }
                
            }
            catch (Exception ex)
            {
                chain = null;
                throw ex;   
            }
            return chain;
        }

        public static connection create()
        {
            if(conn == null)
            {
                conn = new connection();
            }
            return conn;
        }
    }
}
