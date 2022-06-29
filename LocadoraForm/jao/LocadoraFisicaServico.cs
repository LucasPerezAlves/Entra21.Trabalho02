using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraForm.jao
{
    internal class LocadoraFisicaServico
    {
        private List<Endereco> enderecos;

        public LocadoraFisicaServico()
        {
            enderecos = new List<Endereco>();
        }

        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.HorarioAtendimento = enderecoParaAlterar.HorarioAtendimento;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public Endereco ObterPorCodigo(int codigo)
        {
            for (var i = 0;i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Codigo == codigo)
                    return endereco;
            }

            return null;
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for(int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                ultimoCodigo = endereco.Codigo;
            }
            return ultimoCodigo;
        }

        private void SalvarArquivo()
        {
            var enderecoEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("enderecoLocadoraFisica.json", enderecoEmJson);
        }
    }
}
