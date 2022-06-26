using System.Collections.Generic;

// LINHAS COMENTADAS FAZER CORREÇÃO

namespace LocadoraForm.Prim
{
    public class FilmeServico
    {
        private List<Filme> filmes;

        public FilmeServico()
        {
            filmes = new List<Filme>();
        }

        //public void Adicionar(Filme filme)
        //{
        //    filmes.Add(filme);

        //    //SALVAR
        //}

        //public void Editar(Filme filmeEditar)
        //{
        //    for (var i = 0; i < filmes.Count; i++)
        //    {
        //        var filme = filmes[i];

        //        if (filme.Codigo == filmeEditar.Codigo)
        //        {
        //            filme.NomeFilme = filmeEditar.NomeFilme;
        //            filme.GeneroFilme = filmeEditar.GeneroFilme;
        //            filme.ClassificacaoIndicativa = filmeEditar.ClassificacaoIndicativa;

        //            //SALVAR

        //            return;
        //        }
        //    }
        //}

        private void Apagar(Filme filmeApagar)
        {
            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                if (filme.Codigo == filmeApagar.Codigo)
                {
                    filmes.Remove(filme);

                    //SALVAR

                    return;
                }
            }
        }
    }
}
