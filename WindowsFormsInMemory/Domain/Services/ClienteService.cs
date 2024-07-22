
using basededatos;

namespace Domain.Services
{
    public class ClienteService
    {
        //No es ThreadSafe pero sirve para el proposito del ejemplo        
        private static List<Cliente> clientes = new List<Cliente>();

        public IEnumerable<Cliente> GetAll()
        {
            //Devuelvo una lista nueva cada vez que se llama a GetAll
            //pero idealmente deberia implementar un Deep Clone
            return clientes.ToList();
        }

        public Cliente Get(int id)
        {
            return clientes.First(x => x.Id == id);
        }

        public void Add(Cliente cliente)
        {
            cliente.Id = GetNextId();

            clientes.Add(cliente);
        }

        public void Update(Cliente cliente)
        {
            Cliente clienteToUpdate = clientes.First(x => x.Id == cliente.Id);

            clienteToUpdate.Nombre = cliente.Nombre;

        }

        public void Delete(int id)
        {
            clientes.RemoveAll(x => x.Id == id);
        }

        private static int GetNextId()
        {
            int nextId;

            if (clientes.Count > 0) 
            { 
                nextId = clientes.Max(x => x.Id)+1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}