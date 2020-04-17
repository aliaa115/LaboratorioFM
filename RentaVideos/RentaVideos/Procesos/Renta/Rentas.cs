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
    public partial class Rentas : Form
    {
        public Rentas()
        {
            InitializeComponent();
            SQL_rentaEncabezado rentaEncabezado = new SQL_rentaEncabezado();
            rentaEncabezado.obtenerAllEncabezados(Dgv_lista);
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            RentaEncabezadoDetalle rentaEncabezadoDetalle = new RentaEncabezadoDetalle();
            rentaEncabezadoDetalle.Show();
        }
    }
}
