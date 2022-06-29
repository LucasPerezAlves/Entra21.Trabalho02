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
    public partial class LocadoraFisicaForm : Form
    {
        private LocadoraFisicaServico locadoraFisicaServico;

        public LocadoraFisicaForm()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var horarioAtendimento = dateTimePickerHoraAtendimento.Text;

            var dadosValidos = ValidarDados(cep, enderecoCompleto, horarioAtendimento);

            if (dadosValidos == false)
            {
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)

                CadastrarEndereco(cep, enderecoCompleto, horarioAtendimento);

            else
                EditarEndereco(cep, enderecoCompleto, horarioAtendimento);

            
        }

        private void EditarEndereco(string cep, string enderecoCompleto, string horarioAtendimento)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionado;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cep = cep;
            endereco.HorarioAtendimento = horarioAtendimento;

            locadoraFisicaServico.Editar(endereco);
        }

        private void CadastrarEndereco(string cep, string enderecoCompleto, string horarioAtendimento)
        {
            var endereco = new Endereco();
            endereco.Codigo = locadoraFisicaServico.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.HorarioAtendimento = horarioAtendimento;

            locadoraFisicaServico.Adicionar(endereco);
        }

        private bool ValidarDados(string cep, string endereco, string horarioAtendimento)
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

            if (horarioAtendimento.Replace(":", "").Trim().Length != 8)
            {
                MessageBox.Show("Horario de atendimento inválido");

                dateTimePickerHoraAtendimento.Focus();

                return false;
            }

            return false;
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

            dataGridView1.ClearSelection();
        }

        private void labelEndereco_Click(object sender, EventArgs e)
        {

        }
    }
}
