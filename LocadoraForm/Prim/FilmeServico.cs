using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace LocadoraForm.Prim
{
    internal class FilmeServico
    {
        private List<Filme> filmes;

        public FilmeServico()
        {
            filmes = new List<Filme>();

            LerArquivo();
        }

        public void Adicionar(Filme filme)
        {
            filmes.Add(filme);

            SalvarArquivo();
        }

        public void Editar(Filme filmeEditar)
        {
            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                if (filme.Codigo == filmeEditar.Codigo)
                {
                    filme.NomeFilme = filmeEditar.NomeFilme;
                    filme.GeneroFilme = filmeEditar.GeneroFilme;
                    filme.AnoLancamento = filmeEditar.AnoLancamento;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(Filme filmeApagar)
        {
            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                if (filme.Codigo == filmeApagar.Codigo)
                {
                    filmes.Remove(filme);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public List<Filme> ObterTodos()
        {
            return filmes;
        }

        public Filme ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                if (filme.Codigo == codigo)
                    return filme;
            }

            return null;
        }

        public int ObterUltimoCodigo()
        {
            var ultimoCodigo = 0;

            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                ultimoCodigo = filme.Codigo;
            }
            return ultimoCodigo;
        }

        private void LerArquivo()
        {
            if (File.Exists("filmes.json") == false)
                return;

            var filmesJson = File.ReadAllText("filmes.json");
            filmes = JsonConvert.DeserializeObject<List<Filme>>(filmesJson);
        }

        private void SalvarArquivo()
        {
            var filmesJson = JsonConvert.SerializeObject(filmes);
            File.WriteAllText("filmes.json", filmesJson);
        }
    }
}
