using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;


namespace basededatos
{
    public class ClienteAdapter
    {

        public static List<Cliente> GetAll()
        {
            using (var context = BasedatosContext.CreateContext())
            {
                return context.Clientes.ToList();
            }
        }

        public static Cliente? GetOne(int id)
        {
            using (var context = BasedatosContext.CreateContext())
            {
                return context.Clientes.FirstOrDefault(x => x.Id == id);
            }

        }

        public static Cliente? Delete(int id)
        {
            using (var context = BasedatosContext.CreateContext())
            {
                Cliente? cli = GetOne(id);
                if (cli != null)
                {
                    context.Remove(cli);
                    context.SaveChanges();
                }
                return cli; 
            }
        }

        public static void Update(Cliente cliente)
        {
            using (var context = BasedatosContext.CreateContext())
            {
                context.Clientes.Attach(cliente);
                context.Entry(cliente).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static void Add(Cliente cliente)
        {
            using (var context = BasedatosContext.CreateContext())
            {
                context.Clientes.Attach(cliente);
                context.Entry(cliente).State = EntityState.Added;
                context.SaveChanges();
            }

        }
    }
}
