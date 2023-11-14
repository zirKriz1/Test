using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using EquipoProgProyecto.Clases;
using Microsoft.Data.SqlClient;

namespace EquipoProgProyecto.Datos
{
    public class DBHelper
    {
        private SqlConnection conexion;
        private string stringConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=ClubPrograII;Integrated Security=True";
        private static DBHelper instancia;
        private DBHelper()
        {
            conexion = new SqlConnection(stringConexion);
        }
        public static DBHelper GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new DBHelper();
            }   
            return instancia;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        private void Conectar()
        {
            conexion.Open();
        }

        private void Desconectar()
        {
            conexion.Close();
        }
        public DataTable Consultar(string nombreSP)
        {
            Conectar();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        internal DataTable Consultar(string nombreSP, List<Parametro> lParams)
        {
            Conectar();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            foreach (Parametro p in lParams)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }
        
    }
}
