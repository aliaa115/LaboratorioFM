using RentaVideos.Conexion;
using System.Data.Odbc;
using System.Windows.Forms;

namespace RentaVideos.Procesos.Querys
{
    public class SQL_materiales
    {
        transaccion transaccion = new transaccion();

        public void obtenerPrecio(int idMaterial, TextBox txt, string prod)
        {
            try
            {
                string sComando = string.Format("SELECT PRECIO, NOMBRE " +
                    "FROM material " +
                    "WHERE material = {0};", idMaterial);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txt.Text = reader.GetInt32(0).ToString();
                        prod = reader.GetString(1);
                    }
                }
                return;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte");
                return ;
            }
            
        }

    }
}
