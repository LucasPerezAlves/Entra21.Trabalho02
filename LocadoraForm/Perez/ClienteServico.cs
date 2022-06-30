using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace LocadoraForm.Perez
{
    internal class ClienteServico
    {
        private List<Cliente> clientes;
        public ClienteServico()
        {
            clientes = new List<Cliente>();

            LerArquivo();
        }

        public List<Cliente> ObterTodos()
        {
            return clientes;
        }

        public Cliente ObterNomeCliente(string nomeCliente)
        {
            for(int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                if(cliente.Nome == nomeCliente)
                {
                    return cliente;
                }
            }
            return null;
        }

        public void LerArquivo()
        {
            if (File.Exists("clientes.json") == false)
                return;

            var clientesJson = File.ReadAllText("clientes.json");

            clientes = JsonConvert.DeserializeObject<List<Cliente>>(clientesJson);
        }

        public void SalvarArquivo()
        {
            var clientesJson = JsonConvert.SerializeObject(clientes);
            File.WriteAllText("clientes.json", clientesJson);
        }

        public void Apagar(int codigo)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                if (cliente.Codigo == codigo)
                {
                    clientes.Remove(cliente);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public Cliente ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                if (cliente.Codigo == codigo)
                {
                    return cliente;
                }
            }
            return null;
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for(int i = 0;i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                ultimoCodigo = cliente.Codigo;
            }
            return ultimoCodigo;
        }

        public void Cadastrar(Cliente cliente)
        {
            clientes.Add(cliente);

            SalvarArquivo();
        }

        public void Editar(Cliente clienteParaEditar)
        {
            var cliente = ObterPorCodigo(clienteParaEditar.Codigo);

            cliente.Nome = clienteParaEditar.Nome;
            cliente.Codigo = clienteParaEditar.Codigo;
            cliente.Cep = clienteParaEditar.Cep;

            SalvarArquivo();
        }
    }


}
