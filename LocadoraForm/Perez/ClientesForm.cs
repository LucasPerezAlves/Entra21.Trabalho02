using System;
using System.Windows.Forms;

namespace LocadoraForm.Perez
{
    public partial class ClientesForm : Form
    {
        private ClienteServico clienteServico;
        public ClientesForm()
        {
            InitializeComponent();

            //clienteServico = new ClienteServico();


        }

        private void ListarClientes()
        {
            var clientes = clienteServico.ObterTodos();

            dataGridView1.Rows.Clear();

            for(int i = 0; i < clientes.Count; i++)
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
            textBoxCep.Clear();
            textBoxEndereco.Clear();

            dataGridView1.ClearSelection();
        }

        private void EditarDados(string nome, int cep)
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

        private void AdicionarPaciente(string nome, int cep)
        {
            var clientes = new Cliente()
            {
                Codigo = clienteServico.ObterUltimoCodigo() + 1,
                Nome = nome,
                Cep = cep

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
            var cep = Convert.ToInt32(textBoxCep.Text.Trim());

            if (dataGridView1.SelectedRows.Count == 0)
            {
                AdicionarCliente(nome, cep);

                return;
            }
            EditarDados(nome, cep);
        }

        private void AdicionarCliente()
        {
            //var cliente = new Cliente();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
