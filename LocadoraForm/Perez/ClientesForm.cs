using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace LocadoraForm.Perez
{
    public partial class ClientesForm : Form
    {
        private ClienteServico clienteServico;
        public ClientesForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();

            ListarClientes();

            ObterCep();
        }

        private void ListarClientes()
        {
            var clientes = clienteServico.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                dataGridView1.Rows.Add(new object[]
                {
                    cliente.Codigo, cliente.Nome, cliente.Cep
                });
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            maskedTextBoxCep.Clear();
            textBoxEndereco.Clear();

            dataGridView1.ClearSelection();
        }

        private void EditarDados(string nome, string cep)
        {

            var cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Cep = cep;

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            cliente.Codigo = codigo;

            clienteServico.Editar(cliente);

            LimparCampos();
            ListarClientes();
        }

        private void AdicionarCliente(string nome, string cep, string endereco)
        {
            var clientes = new Cliente()
            {
                Codigo = clienteServico.ObterUltimoCodigo() + 1,
                Nome = nome,
                Cep = cep,
                EnderecoCompleto = endereco
            };

            clienteServico.Cadastrar(clientes);

            LimparCampos();

            ListarClientes();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEndereco.Text.Trim();

            var validarDados = ValidarDados(cep, enderecoCompleto);

            if (validarDados == false)
                return;

            if (dataGridView1.SelectedRows.Count == 0)
                CadastrarEnderecos(cep, enderecoCompleto);
            else
                EditarDados(nome, cep);

            PreencherDataGridViewComEnderecos();

            LimparCampos();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente para remover");
                return;
            }

            var resposta = MessageBox.Show("Deseja realmente apagar o endereço?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Teu codigo esta ai");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var cliente = clienteServico.ObterPorCodigo(codigo);

            //clienteServico.Apagar(cliente);

            PreencherDataGridViewComEnderecos();

            dataGridView1.ClearSelection();

        }

        private void ObterCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "").Trim();

            if (cep.Length != 8)
                return;

            var httpClient = new HttpClient();

            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            //if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    var resposta = resultado.Content.ReadAsStringAsync().Result;
            //    var dadosenderecos = JsonConvert.DeserializeObject<EnderecosDadosRequisitados>(resposta);

            //    textBoxEndereco.Text = $"{dadosenderecos.uf} - {dadosenderecos.localidade} - {dadosenderecos.bairro} - {dadosenderecos.logradouro}";
            //}
        }

        private void maskedTextBoxCep_MouseLeave(object sender, EventArgs e)
        {
            ObterCep();
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterCep();
        }

        private bool ValidarDados(string cep, string enderecoCompleto)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP inválido");

                maskedTextBoxCep.Focus();

                return false;
            }

            if (enderecoCompleto.Trim().Length < 10)
            {
                MessageBox.Show("O endereço completo deve ter no minimo 10 caracteres");

                maskedTextBoxCep.Focus();

                return false;
            }

            return true;
        }

        private void radioButtonMenorIdade_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarEnderecos(string cep, string enderecoCompleto)
        {
            var endereco = new Cliente();
            endereco.Codigo = clienteServico.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;

            clienteServico.AdicionarEndereco(endereco);
        }

        private void PreencherDataGridViewComEnderecos()
        {
            var enderecos = clienteServico.ObterTodos();

            dataGridView1.Rows.Clear();
            dataGridView1.ClearSelection();

            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                dataGridView1.Rows.Add(new object[]
                {
                    endereco.EnderecoCompleto,
                    endereco.Nome,
                    endereco.Cep,
                    endereco.Codigo
                });
            }
        }

        private void ApresentarDadosParaEdicao()
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente para editar");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var clientes = clienteServico.ObterPorCodigo(codigo);

            maskedTextBoxCep.Text = clientes.Cep;
            textBoxNome.Text = clientes.Nome;

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
