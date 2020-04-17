using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentaVideos.Procesos.Querys;

namespace RentaVideos.Procesos.Renta
{
    public partial class RentaEncabezadoDetalle : Form
    {
        SQL_materiales materiales = new SQL_materiales();
        SQL_renta sql_renta = new SQL_renta();
        string prod = "";
        int codProd = 0;

        public RentaEncabezadoDetalle()
        {
            InitializeComponent();
            Cbo_membresia.llenarse("cliente", "MEMBRESIA", "NOMBRES");
            Cbo_empleado.llenarse("empleado", "EMPLEADO", "NOMBRES");
            Cbo_producto.llenarse("material", "MATERIAL", "NOMBRE");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Lbl_producto.Text = Cbo_producto.obtenerP() + "-" + Cbo_producto.obtenerU();
            if (int.Parse(Cbo_producto.obtenerP()) <  58 || int.Parse(Cbo_producto.obtenerP()) > 47)
            {
                materiales.obtenerPrecio(int.Parse(Cbo_producto.obtenerP()), Txt_precioTotal, prod);
                codProd = int.Parse(Cbo_producto.obtenerP());
            }
            else if (int.Parse(Cbo_producto.obtenerU()) < 58 || int.Parse(Cbo_producto.obtenerU()) > 47)
            {
                materiales.obtenerPrecio(int.Parse(Cbo_producto.obtenerU()), Txt_precioTotal, prod);
                codProd = int.Parse(Cbo_producto.obtenerU());
            }
            else
            {
                MessageBox.Show("error al encontrar el producto");
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (Lbl_producto.Text == "")
            {
                MessageBox.Show("error al agregar el producto");
            }
            else if (Nud_cantidad.Value == 0)
            {
                MessageBox.Show("error al agregar el producto");
            }
        }

        private void Gpb_agregar_Enter(object sender, EventArgs e)
        {
            int fila = Dgv_movimientoDetalle.RowCount;
            Dgv_movimientoDetalle.Rows.Add();
            Dgv_movimientoDetalle.Rows[fila].Cells[0].Value = fila+1;
            Dgv_movimientoDetalle.Rows[fila].Cells[1].Value = codProd;
            Dgv_movimientoDetalle.Rows[fila].Cells[2].Value = prod;
            Dgv_movimientoDetalle.Rows[fila].Cells[3].Value = Txt_precioTotal.Text;
            Dgv_movimientoDetalle.Rows[fila].Cells[4].Value = Nud_cantidad.Value.ToString();
        }

        private void Btn_guardar_Click_1(object sender, EventArgs e)
        {
            int fila = 0;

            string membresia = "", empleado = "";

            if (int.Parse(Cbo_membresia.obtenerP()) < 58 || int.Parse(Cbo_membresia.obtenerP()) > 47)
            {
                membresia = Cbo_membresia.obtenerP();
            }
            else if (int.Parse(Cbo_membresia.obtenerU()) < 58 || int.Parse(Cbo_membresia.obtenerU()) > 47)
            {
                membresia = Cbo_membresia.obtenerU();
            }

            if (int.Parse(Cbo_empleado.obtenerP()) < 58 || int.Parse(Cbo_empleado.obtenerP()) > 47)
            {
                empleado = Cbo_empleado.obtenerP();
            }
            else if (int.Parse(Cbo_empleado.obtenerU()) < 58 || int.Parse(Cbo_empleado.obtenerU()) > 47)
            {
                empleado = Cbo_empleado.obtenerU();
            }

            string[] encabezado = {
                Txt_codigo.Text,
                membresia,
                empleado,
                Dtp_fechaInic.Value.Date.ToString("yyyy-MM-dd"),
                Dtp_fechaFin.Value.Date.ToString("yyyy-MM-dd"),
                "0",
                "1"
            };

            sql_renta.ingresarEncabezado(encabezado);

            while (fila < Dgv_movimientoDetalle.RowCount)
            {
                string[] detalle =
                {
                    Txt_codigo.Text,
                    Dgv_movimientoDetalle.Rows[fila].Cells[0].Value.ToString(),
                    Dgv_movimientoDetalle.Rows[fila].Cells[1].Value.ToString(),
                    Dgv_movimientoDetalle.Rows[fila].Cells[3].Value.ToString(),
                    Dgv_movimientoDetalle.Rows[fila].Cells[4].Value.ToString()
                };

                sql_renta.ingresarDetalle(detalle);

                fila++;
            }
        }
    }
}
