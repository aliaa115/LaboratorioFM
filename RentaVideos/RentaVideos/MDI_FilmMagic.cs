using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using RentaVideos.Mantenimientos.Forms;
using RentaVideos.Procesos.Renta;

namespace RentaVideos
{
    public partial class MDI_FilmMagic : Form
    {
        private int childFormNumber = 0;
        string usuario;
        public MDI_FilmMagic()
        {
            InitializeComponent();
        }

        private void mant(int tabla)
        {
            Mantenimiento contacto = new Mantenimiento(usuario, tabla);
            contacto.Show();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(noseXD.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog();
        }

        private void MDI_FilmMagic_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
            Lbl_usuario.Text = login.obtenerNombreUsuario();
            usuario = Lbl_usuario.Text;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void bonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(1);
        }

        private void categoriasDeMaterialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mant(2);
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mant(3);
        }

        private void empleadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mant(4);
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(5);
        }

        private void ayudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mant(7);
        }

        private void rentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rentas rentas = new Rentas();
            rentas.Show();
        }
    }
}
