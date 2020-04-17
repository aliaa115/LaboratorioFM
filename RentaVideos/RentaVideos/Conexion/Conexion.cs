using System;
using System.Data.Odbc;

namespace RentaVideos.Conexion
{
    class Conexion
    {
        OdbcConnection conn;
        public Tuple<OdbcConnection, OdbcTransaction> conexion()
        {
            conn = new OdbcConnection("Dsn=rentavideodb");// creacion de la conexion via ODBC
            OdbcTransaction transaccion = null;
            try
            {
                conn.Open();
                transaccion = conn.BeginTransaction();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }

            return Tuple.Create(conn, transaccion);
        }

        public void desconexion()
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }

        }
    }
}
