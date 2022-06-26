using System;
using System.Windows.Forms;

namespace LocadoraForm.Perez
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();

            //clienteServico = new ClienteServico();


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

            }
        }

        private void AdicionarCliente()
        {
            //var cliente = new Cliente();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
