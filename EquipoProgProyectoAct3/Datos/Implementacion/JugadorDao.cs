using EquipoProgProyecto.Clases;
using EquipoProgProyecto.Datos.Interfaz;
using EquipoProgProyecto.Dominio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Datos.Implementacion
{
    public class JugadorDao: IJugadorDao
    {
        public bool Crear(Jugador oJugador)
        {
            bool resultado = true;
            SqlConnection conexion = DBHelper.GetInstancia().ObtenerConexion();
            
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_JUGADOR", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", oJugador.Nombre);
                comando.Parameters.AddWithValue("@Apellido", oJugador.Apellido);
                comando.Parameters.AddWithValue("@Club", oJugador.club.Id);
                comando.Parameters.AddWithValue("@Posicion", oJugador.posicion.idPosicion);
                comando.Parameters.AddWithValue("@NumeroCamiseta", oJugador.Numero);
                comando.Parameters.AddWithValue("@Nacionalidad", oJugador.Pais.IdPais);
                comando.Parameters.AddWithValue("@FechaNacimiento", oJugador.FechaNacimiento);
                comando.Parameters.AddWithValue("@Altura", oJugador.Altura);
                comando.Parameters.AddWithValue("@Peso", oJugador.Peso);
                comando.ExecuteNonQuery();

            }
            catch
            {
                
            }
            finally
            {
                if (conexion != null) conexion.Close();
            }
            return resultado;
        }
        public List<Clases.Jugador> GetJugador()
        {
            throw new NotImplementedException();
        }
        public bool Actualizar()
        {
            throw new NotImplementedException();
        }
        public bool Eliminar()
        {
            throw new NotImplementedException();
        }
        public List<Pais> GetPais()
        {
            List<Pais> lPaises = new List<Pais>();
            DataTable tabla = DBHelper.GetInstancia().Consultar("SP_CONSULTAR_PAIS");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["id_pais"].ToString());
                string nombre = fila["nombre"].ToString();
                Pais c = new Pais(codigo, nombre);
                lPaises.Add(c);
            }
            return lPaises;
        }

        public List<Posicion> GetPosicion()
        {
            List<Posicion> lPosiciones = new List<Posicion>();
            DataTable tabla = DBHelper.GetInstancia().Consultar("SP_CONSULTAR_POSICION");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["IDPosicion"].ToString());
                string nombre = fila["NombrePosicion"].ToString();
                Posicion c = new Posicion(codigo, nombre);
                lPosiciones.Add(c);
            }
            return lPosiciones;
        }

        public List<Club> GetClub()
        {
            List<Club> lClubes = new List<Club>();
            DataTable tabla = DBHelper.GetInstancia().Consultar("SP_CONSULTAR_CLUB");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["IDPosicion"].ToString());
                string nombre = fila["NombreClub"].ToString();
                int ciudad = int.Parse(fila["Ciudad"].ToString());
                string estadio = fila["Estadio"].ToString();
                DateTime Fecha = Convert.ToDateTime(fila["fechaFundacion"]);
                lClubes.Add(new Club(codigo, nombre, ciudad, estadio, Fecha));
            }
            return lClubes;
        }

        public bool BorrarOrden(int nroOrden)
        {
            bool aux = true;
            SqlConnection conexion = DBHelper.GetInstancia().ObtenerConexion();
            SqlTransaction transaccion = null;
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_BORRAR_ORDEN", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                Parametro param = new Parametro("@id_orden", nroOrden);
                comando.Parameters.AddWithValue(param.Nombre, param.Valor);
                comando.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                    aux = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return aux;
        }
    }
}

