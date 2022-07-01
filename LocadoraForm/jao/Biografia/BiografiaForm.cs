using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraForm.jao
{
    public partial class BiografiaForm : Form
    {
        private BiografiaServico biografiaServico;
        private LocadoraFisicaServico LocadoraFisicaServico;

        public BiografiaForm()
        {
            InitializeComponent();

            biografiaServico = new BiografiaServico();

            LocadoraFisicaServico = new LocadoraFisicaServico();

            PreencherDataGridViewComBiografia();

            PreencherComboBoxComAsLocadoras();
        }

        private void PreencherComboBoxComAsLocadoras()
        {
            var locadoras = biografiaServico.ObterTodos();
        }

        private void BiografiaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
