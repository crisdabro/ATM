using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace ATM.DAO
{
    public class ConnectBDD
    {
        private const string ConnectionString = "Server=127.0.0.1;Uid=atm;Pwd=123;Database=test;";
       
        

        static public SqlConnection Connection = new SqlConnection(ConnectionString);

        static public void Conectar()
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
        }

        static public void Desconectar()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }

        static public DataTable CargarDatos(string commandtext)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(commandtext, Connection);
                Conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch
            {
                throw new Exception("Error al cargar datos");
            }
        }

        static public void EjecutarSql(string cmdtext)
        {
            SqlCommand cmd = new SqlCommand(cmdtext, Connection);
            Conectar();
            cmd.ExecuteNonQuery();
            Desconectar();
        }
    }
}
