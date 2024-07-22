using basededatos;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Services
{
    public class ClienteService
    {
        private ClienteAdapter clienteAdapter;

        public ClienteService()
        {
            clienteAdapter = new ClienteAdapter();
        }

        public IEnumerable<Cliente> GetAll()
        {
            return clienteAdapter.GetAll();
        }

        public Cliente Get(int id)
        {
            return clienteAdapter.Get(id);
        }

        public void Add(Cliente cliente)
        {
            cliente.State = "New";
            clienteAdapter.Save(cliente);
        }

        public void Update(Cliente cliente)
        {
            cliente.State = "Modified";
            clienteAdapter.Save(cliente);
        }

        public void Delete(int id)
        {
            Cliente cliente = clienteAdapter.Get(id);
            if (cliente != null)
            {
                cliente.State = "Deleted";
                clienteAdapter.Save(cliente);
            }
        }
    }
}
