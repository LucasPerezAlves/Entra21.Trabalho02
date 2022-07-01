using LocadoraForm.jao;
using LocadoraForm.Perez;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraForm
{
    public partial class MenuLocadoraForm : Form
    {
        public MenuLocadoraForm()
        {
            InitializeComponent();
        }

        private void buttonLocadoraFisica_Click(object sender, EventArgs e)
        {
            var locadoraFisicaForm = new LocadoraFisicaForm();
            locadoraFisicaForm.ShowDialog();
        }

        private void buttonBiografia_Click(object sender, EventArgs e)
        {
            var biografiaForm = new BiografiaForm();
            biografiaForm.ShowDialog();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            var clientesForm = new ClientesForm();
            clientesForm.ShowDialog();
        }
    }
}
