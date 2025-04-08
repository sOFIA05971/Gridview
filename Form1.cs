using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gridview
{
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DGdatos.DataSource = null;
            DGdatos.DataSource = acc.mostrarG();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnio_Click(object sender, EventArgs e)
        {
            if (acc.EliminarAnio(Convert.ToInt32(txbAnio.Text)))

            {
                MessageBox.Show("Eliminado con exito");
            }
            else
            {
                MessageBox.Show("Fallo al eliminar");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (acc.AgregarA(tbxDirector.Text, Convert.ToInt32(txbAnio.Text), tbxClasificacion.Text, tbxGenero.Text, tbxDuracion.Text))
                MessageBox.Show("Agregado con exito");

            else
                MessageBox.Show("Fallo al agregado");

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (acc.ActualizarG(tbxDirector.Text, Convert.ToInt32(txbAnio.Text), tbxClasificacion.Text, tbxGenero.Text, tbxDuracion.Text))
            {
                MessageBox.Show("Actualizado con éxito");
                DGdatos.DataSource = null;
                DGdatos.DataSource = acc.mostrarG();
            }
            else
            {
                MessageBox.Show("Fallo al actualizar");
            }
        }
    }
}
