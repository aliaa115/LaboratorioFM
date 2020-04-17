using RentaVideos.Conexion;
using System.Data.Odbc;
using System.Windows.Forms;

namespace RentaVideos.Procesos.Querys
{
    public class SQL_renta
    {

        transaccion transaccion = new transaccion();

        public void ingresarDetalle(string[] datos)
        {
            string sComando = string.Format("INSERT INTO renta_detalle VALUES " +
                "( {0}, {1}, {2}, {3}, {4}, {5} );",
                datos[0], datos[1], datos[2], datos[3], datos[4], datos[5] );

            try
            {
                transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void ingresarEncabezado(string [] datos)
        {
            string sComando = string.Format("INSERT INTO renta_encabezado VALUES " +
                "( {0} , {1}, {2}, '{3}', '{4}', {5}, {6}, {7} );", 
                datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7]);

            try
            {
                transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void obtenerAllEncabezados(DataGridView dgv)
        {
            transaccion transaccion = new transaccion();

            try
            {
                string sComando = string.Format("SELECT ID_ENCABEZADO, MEMBRESIA, FECHA_INICIO, ESTADO " +
                    "FROM renta_encabezado;");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);
                int fila = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[fila].Cells[0].Value = reader.GetInt32(0);
                        dgv.Rows[fila].Cells[1].Value = reader.GetInt32(1);
                        dgv.Rows[fila].Cells[2].Value = reader.GetDate(2);
                        dgv.Rows[fila].Cells[3].Value = reader.GetInt32(3);
                        fila++;
                    }
                }
                return ;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener Renta");
                return;
            }
        }

    }
}
