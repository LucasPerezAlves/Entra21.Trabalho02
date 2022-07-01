using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraForm.jao
{
    public partial class LocadoraFisicaForm : Form
    {
        private LocadoraFisicaServico locadoraFisicaServico;

        public LocadoraFisicaForm()
        {
            InitializeComponent();

            locadoraFisicaServico = new LocadoraFisicaServico();

            PreencherDataGridViewComEnderecos();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var horarioAtendimento = dateTimePickerHoraAtendimento.Value.ToString("HH:mm");
            var nomeLocadora = textBoxNomeLocadora.Text;

            var dadosValidos = ValidarDados(cep, enderecoCompleto, horarioAtendimento, nomeLocadora);

            if (dadosValidos == false)
            {
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)

                CadastrarEndereco(cep, enderecoCompleto, horarioAtendimento, nomeLocadora);

            else
                EditarEndereco(cep, enderecoCompleto, horarioAtendimento, nomeLocadora);

            PreencherDataGridViewComEnderecos();

            LimparCampos();
        }

        private void EditarEndereco(string cep, string enderecoCompleto, string horarioAtendimento, string nomeLocadora)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionado;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cep = cep;
            endereco.HorarioAtendimento = horarioAtendimento;
            endereco.NomeLocadora = nomeLocadora;

            locadoraFisicaServico.Editar(endereco);
        }

        private void PreencherDataGridViewComEnderecos()
        {
            var enderecos = locadoraFisicaServico.ObterTodos();

            dataGridView1.Rows.Clear();

            dataGridView1.ClearSelection();

            for(var i = 0;i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                dataGridView1.Rows.Add(new object[]
                {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    endereco.HorarioAtendimento,
                    endereco.NomeLocadora
                });
            }
        }

        private void CadastrarEndereco(string cep, string enderecoCompleto, string horarioAtendimento, string nomeLocadora)
        {
            var endereco = new Endereco();
            endereco.Codigo = locadoraFisicaServico.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.HorarioAtendimento = horarioAtendimento;
            endereco.NomeLocadora = nomeLocadora;

            locadoraFisicaServico.Adicionar(endereco);
        }

        private bool ValidarDados(string cep, string endereco, string horarioAtendimento, string nomeLocadora)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP inválido");

                maskedTextBoxCep.Focus();

                return false;
            }

            if (endereco.Trim().Length < 10)
            {
                MessageBox.Show("Endereço completo deve conter no mínimo 10 caracteres");

                textBoxEnderecoCompleto.Focus();

                return false;
            }

            if (horarioAtendimento.Replace(":", "").Trim().Length != 4)
            {
                MessageBox.Show("Horario de atendimento inválido");

                dateTimePickerHoraAtendimento.Focus();

                return false;
            }
            if (nomeLocadora.Trim().Length < 1)
            {
                MessageBox.Show("nome da locadora inválido");

                textBoxNomeLocadora.Focus();
            }

            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            dateTimePickerHoraAtendimento.Text = "";
            textBoxNomeLocadora.Text = "";

            dataGridView1.ClearSelection();
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
            var endereco = locadoraFisicaServico.ObterPorCodigo(codigo);

            maskedTextBoxCep.Text = endereco.Cep;
            textBoxEnderecoCompleto.Text = endereco.EnderecoCompleto;
            dateTimePickerHoraAtendimento.Text = endereco.HorarioAtendimento;
            textBoxNomeLocadora.Text = endereco.NomeLocadora;
        }

        private void EnderecosForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComEnderecos();
        }

        private void labelEndereco_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para remover");

                return;
            }

            var resposta = MessageBox.Show(
                "Deseja realmente apagar o endereço?", "Aviso",
                MessageBoxButtons.YesNo);

            if(resposta != DialogResult.Yes)
            {
                MessageBox.Show("Operação executada com sucesso");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var endereco = locadoraFisicaServico.ObterPorCodigo(codigo);

            locadoraFisicaServico.Apagar(endereco);

            PreencherDataGridViewComEnderecos();

            dataGridView1.ClearSelection();
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "").Trim();

            if(cep.Length != 8)
            {
                return;
            }

            var httpClient = new HttpClient();

            var resultado = httpClient.GetAsync(
                $@"https://viacep.com.br/ws/{cep}/json/").Result;

            if(resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text =
                    $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private void LocadoraFisicaForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComEnderecos();
        }

    }
}
