using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraForm.Perez
{
    internal class ClienteServico
    {
        private List<Cliente> clientes;
    }
    
    public ClienteServico()
    {
        clientes = new List<Cliente>();

        LerArquivo();
    }

    public void LerArquivo()
    {
        if (File.Exists("clientes.json") == false)
            return;

        var clientesJson = File.ReadAllText("clientes.json");

        clientes = JsonConvert.DeserializeObject<List<Cliente>>(clientesJson)
    }

    public void SalvarArquivo()
    {
        var clientesJson = JsonConvert.SerializeObject(clientes);
        File.ReadAllText("clientes.json", clientesJson);
    }

    public void Apagar(int codigo)
    {
        for(int i = 0; i < clientes.Count; i++)
        {
            var cliente = clientes[i];

            if(cliente.Codigo == codigo)
            {
                clientes.Remove(cliente);

                SalvarArquivo();

                return;
            }
        }
    }

    public Cliente ObterPorCodigo(int codigo)
    {
        for(int i = 0; i < clientes.Count; i++)
        {
            var cliente = clientes[i];

            if(cliente.Codigo == codigo)
            {
                return cliente;
            }
        }
        return null;
    }

}
