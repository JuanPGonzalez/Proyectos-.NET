using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;


namespace basededatos
{
    public class ClienteAdapter
    {
        private List<Cliente> Clientes = new List<Cliente>();
        private SqlConnection sqlConn;

        private void OpenConnection()
        {
            // Add your connection string here
            string connectionString = "server=localhost;port=3306;database=basedatos;user=root;password=root";
            sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
        }

        private void CloseConnection()
        {
            if (sqlConn != null && sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
            }
        }
        public List <Cliente> GetAll()
        {

            this.OpenConnection();

            SqlCommand cmdCliente = new SqlCommand("select * from clientes", sqlConn);

            SqlDataReader drCliente= cmdCliente.ExecuteReader();

            while (drCliente.Read())
            {
                Cliente cli = new Cliente();

                cli.Id = (int)drCliente["id"];
                cli.Nombre = (string)drCliente["nombre"];

                Clientes.Add(cli);
            }

            drCliente.Close();
            this.CloseConnection();

            return Clientes;
        }

        public Cliente Get(int id)
        {
            Cliente cli = new Cliente();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCliente = new SqlCommand("select * from clientes where id @id", sqlConn);
                cmdCliente.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                SqlDataReader drCliente = cmdCliente.ExecuteReader();

                if (drCliente.Read())
                {
                    
                    cli.Id = (int)drCliente["id"];
                    cli.Nombre = (string)drCliente["nombre"];

                }

                drCliente.Close();
            }
            catch(Exception ex)
            {
                Exception exception = new Exception("Error GetOne", ex);
                throw exception;
            }
            finally
            {
                this.CloseConnection();
            }
            return cli;
        }

        public void Delete (int id)
        {
            try
            {
                this.OpenConnection();

                SqlCommand sqlDelete = new SqlCommand("delete cliente where id = @id", sqlConn);

                sqlDelete.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                sqlDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception exception = new Exception("Error Delete",ex);
                throw exception;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Cliente cliente)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE clientes SET nombre = @nombre WHERE id = @id", sqlConn);
            }
            catch (Exception ex)
            {
                 Exception exception = new Exception("Error Update", ex);
                throw exception;
            } 
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Add(Cliente cliente)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insert = new SqlCommand("insert into clientes(nombre) Values(@nombre) Select @@indentity", sqlConn);
                insert.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = cliente.Nombre;
                cliente.Id = Decimal.ToInt32((decimal) insert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception exception = new Exception("Error Insert", ex);
                throw exception;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        public void Save(Cliente cliente)
        {
            if (cliente.State == States.Deleted)
            {
                this.Delete(cliente.Id);
            }
            else if (cliente.State == States.New)
            {
                this.Add(cliente);
            }
            else if (cliente.State == States.Modified)
            {
                this.Update(cliente);
            }
            cliente.State = States.Unmodified;
        }
    }
}
