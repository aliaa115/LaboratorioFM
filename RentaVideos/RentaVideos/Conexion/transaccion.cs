using System.Data.Odbc;
using System.Windows.Forms;

namespace RentaVideos.Conexion
{
    class transaccion
    {

        public void insertarDatos(params string[] sSentencia)
        {
            Conexion conexion = new Conexion();
            var resultado = conexion.conexion();
            OdbcCommand comando = resultado.Item1.CreateCommand();
            OdbcTransaction transaccion = resultado.Item2;
            comando.Transaction = transaccion;

            try
            {
                foreach (string sentencia in sSentencia)
                {
                    comando.CommandText = sentencia;
                    comando.ExecuteNonQuery();
                }

                transaccion.Commit();
            }
            catch (OdbcException ex)
            {
                transaccion.Rollback();
                MessageBox.Show(ex.Message, "Error en sentencia");
            }
            finally
            {
                conexion.desconexion();
            }
        }

        public OdbcDataReader ConsultarDatos(string sParametro)
        {
            Conexion conexion = new Conexion();
            var resultado = conexion.conexion();
            OdbcCommand comando = resultado.Item1.CreateCommand();
            OdbcTransaction transaction = resultado.Item2;
            OdbcDataReader reader;
            try
            {
                comando.Transaction = transaction;
                comando.CommandText = sParametro;
                reader = comando.ExecuteReader();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            return reader;
        }
    }
}
