using System;
using System.Windows.Forms;

namespace LocadoraForm
{
    public partial class FilmesForm : Form
    {

        public FilmesForm()
        {
            InitializeComponent();

            //filmeServico = new FilmeServico();
        }

        private void LimparCampos()
        {
            textBoxNomeFilme.Clear();
            comboBoxGeneroFilme.SelectedIndex = -1;
        }

        private void DadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione o filme que deseja editar");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            //var filme = filmeServico.ObterPorCodigo(codigo);

            //textBoxNomeFilme.Text = filme.NomeFilme;
        }
    }
}
