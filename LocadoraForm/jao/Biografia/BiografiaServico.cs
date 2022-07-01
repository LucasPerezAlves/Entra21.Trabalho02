using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraForm.jao
{
    internal class BiografiaServico
    {
        private List<Biografia> biografias;

        public BiografiaServico()
        {
            biografias = new List<Biografia>();

            LerArquivo();
        }

        public void Adicionar(Biografia biografia)
        {
            biografias.Add(biografia);

            SalvarArquivo();
        }

        public void Editar(Biografia biografiaParaAlterar)
        {
            for(var i = 0; i < biografias.Count; i++)
            {
                var biografia = biografias[i];

                if(biografia.Codigo == biografiaParaAlterar.Codigo)
                {
                    biografia.Nome = biografiaParaAlterar.Nome;
                    biografia.DataFundacao = biografiaParaAlterar.DataFundacao;
                    biografia.MotivoFundacao = biografiaParaAlterar.MotivoFundacao;
                    biografia.Parceirias = biografiaParaAlterar.Parceirias;
                    biografia.Sinopse = biografiaParaAlterar.Sinopse;
                    biografia.Locadora = biografiaParaAlterar.Locadora;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(Biografia biografiaParaApagar)
        {
            for(var i = 0; i < biografias.Count; i++)
            {
                var biografia = biografias[i];

                if (biografia.Codigo == biografiaParaApagar.Codigo)
                {
                    biografias.Remove(biografia);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public List<Biografia> ObterTodos()
        {
            return biografias;
        }

        public Biografia ObterPorCodigo(int codigo)
        {
            for(var i = 0; i < biografias.Count; i++)
            {
                var biografia = biografias[i];

                if(biografia.Codigo == codigo)
                {
                    return biografia;
                }
            }

            return null;
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for(int i = 0; i < biografias.Count; i++)
            {
                var biografia = biografias[i];

                ultimoCodigo = biografia.Codigo;
            }
            return ultimoCodigo;
        }

        public void SalvarArquivo()
        {
            var biografiaEmJson = JsonConvert.SerializeObject(biografias);
            File.WriteAllText("biografia.json", biografiaEmJson);
        }

        public void LerArquivo()
        {
            if(File.Exists("biografia.json") == false)
            {
                return;
            }

            var biografiaEmJson = File.ReadAllText("biografia.json");
            biografias = JsonConvert.DeserializeObject<List<Biografia>>(biografiaEmJson);
        }
    }
}
