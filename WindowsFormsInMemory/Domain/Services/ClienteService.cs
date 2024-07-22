using basededatos;
using MySqlX.XDevAPI;
using System.Collections.Generic;
using System.Linq;


namespace Domain.Services
{
    public class ClienteService
    {
       
        public List<Cliente> GetAll()
        {
            return ClienteAdapter.GetAll();
        }

        public Cliente? Get(int id)
        {
            return ClienteAdapter.GetOne(id);
        }

        public void Add(Cliente cliente)
        {
            
            ClienteAdapter.Add(cliente);
        }

        public void Update(Cliente cliente)
        {
            
            ClienteAdapter.Update(cliente);
        }

        public void Delete(int id)
        {
            ClienteAdapter.Delete(id);
        }
    }
}
