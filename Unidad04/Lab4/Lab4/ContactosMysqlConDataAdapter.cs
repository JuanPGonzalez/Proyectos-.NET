using MySql.Data.MySqlClient;
using System.Data;

namespace Lab4
{
    internal class ContactosMysqlConDataAdapter : Contactos
    {
        protected string connectionString
        {
            get
            {
                return "server=localhost;database=net;uid=root;pwd=root"; // ;pwd=123entre";
            }
        }

        private MySqlDataAdapter adapter;

        public ContactosMysqlConDataAdapter()
        {
            adapter = new MySqlDataAdapter();

            adapter.InsertCommand = new MySqlCommand(
                "insert into contactos values(@id,@nombre,@apellido,@email,@telefono)");
            adapter.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
            adapter.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 20, "nombre");
            adapter.InsertCommand.Parameters.Add("@apellido", MySqlDbType.VarChar, 20, "apellido");
            adapter.InsertCommand.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");
            adapter.InsertCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 10, "telefono");

            adapter.UpdateCommand = new MySqlCommand(
                "update contactos set nombre=@nombre, apellido=@apellido, email=@email, telefono=@telefono " +
                "where id=@id");
            adapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
            adapter.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 20, "nombre");
            adapter.UpdateCommand.Parameters.Add("@apellido", MySqlDbType.VarChar, 20, "apellido");
            adapter.UpdateCommand.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");
            adapter.UpdateCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 10, "telefono");

            adapter.DeleteCommand = new MySqlCommand("delete from contactos where id=@id");
            adapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
        }

        public override DataTable getTabla()
        {
            adapter = new MySqlDataAdapter("select * from contactos", this.connectionString);
            DataTable contactos = new DataTable();
            adapter.Fill(contactos);
            return contactos;
        }

        public override void aplicaCambios()
        {
            using (MySqlConnection Conn = new MySqlConnection(this.connectionString))
            {
                adapter.InsertCommand.Connection = Conn;
                adapter.UpdateCommand.Connection = Conn;
                adapter.DeleteCommand.Connection = Conn;
                adapter.Update(this.misContactos);
            }
        }

    }
}

