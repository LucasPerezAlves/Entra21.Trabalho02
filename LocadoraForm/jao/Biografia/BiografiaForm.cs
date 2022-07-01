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
        private LocadoraFisicaServico locadoraFisicaServico;

        public BiografiaForm()
        {
            InitializeComponent();

            biografiaServico = new BiografiaServico();

            locadoraFisicaServico = new LocadoraFisicaServico();

            PreencherDataGridViewComBiografia();

            PreencherComboBoxComAsLocadoras();
        }

        private void PreencherComboBoxComAsLocadoras()
        {
            var enderecos = locadoraFisicaServico.ObterTodos();

            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];
                comboBoxLocadora.Items.Add(endereco.NomeLocadora);
            }
        }

        private void BiografiaForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComBiografia();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNome.Text = "";
            dateTimePickerDiaFundacao.Text = "";
            textBoxMotivoFundacao.Text = "";
            textBoxParcerias.Text = "";
            textBoxSinopse.Text = "";
            comboBoxLocadora.SelectedIndex = -1;

            dataGridView1.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var dataFundacao = dateTimePickerDiaFundacao.Value.ToString("dd:MM:yyyy");
            var motivoFundacao = textBoxMotivoFundacao.Text;
            var parcerias = textBoxParcerias.Text;
            var sinopse = textBoxSinopse.Text;
            var locadora = Convert.ToString(comboBoxLocadora);

            var dadosValidos = ValidarDados(nome, dataFundacao, motivoFundacao, parcerias, sinopse, locadora);

            if(dadosValidos == false)
            {
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
                cadastrarBiografia(nome, dataFundacao, motivoFundacao, parcerias, sinopse, locadora);
            else
                EditarBiografia(nome, dataFundacao, motivoFundacao, parcerias, sinopse, locadora);

            PreencherDataGridViewComBiografia();

            LimparCampos();
        }

        private void EditarBiografia(string nome, string dataFundacao, string motivoFundacao, string parcerias, string sinopse, string locadora)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var biografia = new Biografia();
            biografia.Codigo = codigoSelecionado;
            biografia.Nome = nome;
            biografia.DataFundacao = dataFundacao;
            biografia.MotivoFundacao = motivoFundacao;
            biografia.Parceirias = parcerias;
            biografia.Sinopse = sinopse;
            biografia.Locadora = locadoraFisicaServico.ObterPorNomeLocadora(locadora);

            biografiaServico.Editar(biografia);
        }
        private void cadastrarBiografia(string nome, string dataFundacao, string motivoFundacao, string parcerias, string sinopse, string locadora)
        {
            var biografia = new Biografia();
            biografia.Codigo = biografiaServico.ObterUltimoCodigo() + 1;
            biografia.Nome = nome;
            biografia.DataFundacao = dataFundacao;
            biografia.Parceirias = parcerias;
            biografia.Sinopse = sinopse;
            biografia.Locadora = locadoraFisicaServico.ObterPorNomeLocadora(locadora);

            biografiaServico.Adicionar(biografia);
        }

        private void PreencherDataGridViewComBiografia()
        {
            var biografias = biografiaServico.ObterTodos();

            dataGridView1.Rows.Clear();

            dataGridView1.ClearSelection();

            for (var i = 0; i < biografias.Count; i++)
            {
                var biografia = biografias[i];

                dataGridView1.Rows.Add(new object[]
                {
                    biografia.Codigo,
                    biografia.Nome,
                    biografia.DataFundacao,
                    biografia.Parceirias,
                    biografia.Sinopse,
                    biografia.Locadora.NomeLocadora
                });
            }
        }

        private bool ValidarDados(string nome, string dataFundacao, string motivoFundacao, string parcerias, string sinopse, string locadora)
        {
            if(nome.Trim().Length < 1)
            {
                MessageBox.Show("Nome inválido");

                textBoxNome.Focus();

                return false;
            }

            if(dataFundacao.Replace(":", "").Trim().Length != 8)
            {
                MessageBox.Show("Data inválida");

                dateTimePickerDiaFundacao.Focus();

                return false;
            }

            if(parcerias.Trim().Length < 1)
            {
                MessageBox.Show("Parceiria inválida");

                textBoxParcerias.Focus();

                return false;
            }

            if(sinopse.Trim().Length < 10)
            {
                MessageBox.Show("Sinopse deve conter no mínimo 10 caracteres");

                textBoxSinopse.Focus();

                return false;
            }

            if(comboBoxLocadora.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma locadora");

                comboBoxLocadora.DroppedDown = true;

                return false;
            }

            return true;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma biografia para remover");

                return;
            }

            var resposta = MessageBox.Show("Deseja realmente apagar o endereço?", "Aviso",
                MessageBoxButtons.YesNo);

            if(resposta != DialogResult.Yes)
            {
                MessageBox.Show("Seu arquivo esta salvo");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var biografia = biografiaServico.ObterPorCodigo(codigo);

            biografiaServico.Apagar(biografia);

            PreencherDataGridViewComBiografia();

            dataGridView1.ClearSelection();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void ApresentarDadosParaEdicao()
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para editar");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var biografia = biografiaServico.ObterPorCodigo(codigo);

            textBoxNome.Text = biografia.Nome;
            dateTimePickerDiaFundacao.Text = biografia.DataFundacao;
            textBoxMotivoFundacao.Text = biografia.MotivoFundacao;
            textBoxParcerias.Text = biografia.Parceirias;
            textBoxSinopse.Text = biografia.Sinopse;
            comboBoxLocadora.SelectedItem = biografia.Locadora.NomeLocadora;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ApresentarDadosParaEdicao();
        }
    }
}
