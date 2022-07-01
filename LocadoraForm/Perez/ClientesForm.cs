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
            {
                AdicionarCliente(nome, cep, enderecoCompleto);

                return;
            }
            EditarDados(nome, cep);
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var nome = linhaSelecionada.Cells[1].Value.ToString();

            textBoxNome.Text = nome;

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var quantidadeLinhaSelecionada = dataGridView1.SelectedRows.Count;

            if (quantidadeLinhaSelecionada == 0)
            {
                MessageBox.Show("selecione um cliente");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "aviso", MessageBoxButtons.YesNo);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                var linhaSelecionada = dataGridView1.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                clienteServico.Apagar(codigoSelecionado);

                ListarClientes();
            }
        }

        private void ObterCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "").Trim();

            if (cep.Length != 8)
                return;

            var httpClient = new HttpClient();

            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resposta = resultado.Content.ReadAsStringAsync().Result;
                var dadosEnderecos = JsonConvert.DeserializeObject<EnderecosDadosRequisitados>(resposta);

                textBoxEndereco.Text = $"{dadosEnderecos.Uf} - {dadosEnderecos.Localidade} - {dadosEnderecos.Bairro} - {dadosEnderecos.Logradouro}";
            }
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
            if(cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP inválido");

                maskedTextBoxCep.Focus();

                return false;
            }

            if(enderecoCompleto.Trim().Length < 10)
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
            //endereco.Codigo = Cliente.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;

            //ClienteServico.Adicionar(endereco);
        }
    }
}
