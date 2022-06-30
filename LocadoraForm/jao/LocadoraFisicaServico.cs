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

        private void SalvarArquivo()
        {
            var enderecoEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("enderecoLocadoraFisica.json", enderecoEmJson);
        }
    }
}
