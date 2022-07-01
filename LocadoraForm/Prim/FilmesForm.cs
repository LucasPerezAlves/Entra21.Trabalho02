using System;
using System.Windows.Forms;
using LocadoraForm.Perez;
using LocadoraForm.Prim;

// LINHAS COMENTADAS, FAZER CORREÇÃO
namespace LocadoraForm
{
    public partial class FilmesForm : Form
    {
        private FilmeServico filmeServico;
        private ClienteServico clienteServico;

        public FilmesForm()
        {
            InitializeComponent();

            filmeServico = new FilmeServico();

            clienteServico = new ClienteServico();

            PreencherDataGrideViewComFilmes();
        }

        private void LimparCampos()
        {
            textBoxNomeFilme.Clear();
            textBoxGeneroFilme.Clear();
            dateTimePickerAnoLancamento.ResetText();

            dataGridView1.ClearSelection();
        }

        private void FilmesForm_Load(object sender, EventArgs e)
        {
            PreencherDataGrideViewComFilmes();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            DadosParaEditar();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente para apagar");

                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "AVISO", MessageBoxButtons.YesNo);

            if (opcaoEscolhida != DialogResult.Yes)
            {
                MessageBox.Show("Filme não retirado do cadastro");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var filme = filmeServico.ObterPorCodigo(codigo);

            filmeServico.Apagar(filme);

            PreencherDataGrideViewComFilmes();

            dataGridView1.ClearSelection();
        }

        

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void CadastrarFilme(string nomeFilme, string generoFilme, DateTime anoLancamento)
        {
            var filme = new Filme();
            filme.Codigo = filmeServico.ObterUltimoCodigo() + 1;
            filme.NomeFilme = nomeFilme;
            filme.GeneroFilme = generoFilme;
            filme.AnoLancamento = anoLancamento;

            filmeServico.Adicionar(filme);
        }

        private void EditarEndereco(string nomeFilme, string generoFilme, DateTime anoLancamento)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var filme = new Filme();
            filme.Codigo = codigoSelecionado;
            filme.NomeFilme = nomeFilme;
            filme.GeneroFilme = generoFilme;
            filme.AnoLancamento = anoLancamento;

            filmeServico.Editar(filme);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nomeFilme = textBoxNomeFilme.Text;
            var generoFilme = textBoxGeneroFilme.Text;
            var anoLancamento = dateTimePickerAnoLancamento.Value;

            var dadosValidos = ValidarDados(nomeFilme, generoFilme, anoLancamento);

            if (dadosValidos == false)
                return;

            if (dataGridView1.SelectedRows.Count == 0)
                CadastrarFilme(nomeFilme, generoFilme, anoLancamento);
            else
                EditarEndereco(nomeFilme, generoFilme, anoLancamento);

            PreencherDataGrideViewComFilmes();

            LimparCampos();

        }

        private void DadosParaEditar()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um filme que deseja editar");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var filme = filmeServico.ObterPorCodigo(codigo);

            textBoxNomeFilme.Text = filme.NomeFilme;
            textBoxGeneroFilme.Text = filme.GeneroFilme;
            dateTimePickerAnoLancamento.Text = filme.AnoLancamento.ToString();
        }

        private void PreencherDataGrideViewComFilmes()
        {
            var filmes = filmeServico.ObterTodos();

            dataGridView1.Rows.Clear();

            dataGridView1.ClearSelection();

            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                dataGridView1.Rows.Add(new object[]
                {
                    filme.Codigo,
                    filme.NomeFilme,
                    filme.GeneroFilme,
                    filme.AnoLancamento.ToString("dd/MM/yyyy")
                });
            }
        }

        private bool ValidarDados(string nomeFilme, string generoFilme, DateTime anoLancamento)
        {
            if (nomeFilme.Length < 3 && nomeFilme.Length > 30)
            {
                MessageBox.Show("Nome do filme é inválido");

                textBoxNomeFilme.Focus();

                return false;
            }

            if (textBoxGeneroFilme.TextLength < 4 && textBoxGeneroFilme.TextLength > 16)
            {
                MessageBox.Show("Gênero do filme é inválido");

                return false;
            }

            if (dateTimePickerAnoLancamento.Text.Replace("/", "").Trim().Length != 8)
            {
                MessageBox.Show("Data de Lançamento inválida");

                dateTimePickerAnoLancamento.Focus();

                return false;
            }
            return true;
        }
    }
}
