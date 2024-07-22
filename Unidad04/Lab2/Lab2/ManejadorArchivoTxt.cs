using System;
using System.Data;
using System.Data.OleDb;

namespace Lab2
{
    public class ManejadorArchivoTxt : ManejadorArchivo
    {
        protected string connectionString
        {
            get
            {
                return @"Provider=Microsoft.Jet.OLEDB.16.0;Data Source=C:\Proyectos\Unidades\Unidad 04\Lab02\Lab02\bin\Debug;Extended Properties='text;HDR=Yes;FMT=Delimited'";
            }
        }

        public override DataTable getTabla()
        {
            using (OleDbConnection Conn = new OleDbConnection(connectionString))
            {
                OleDbCommand cmdSelect = new OleDbCommand("SELECT * FROM agenda.txt", Conn);
                Conn.Open();
                OleDbDataReader reader = cmdSelect.ExecuteReader();
                DataTable contactos = new DataTable();
                if (reader != null)
                {
                    contactos.Load(reader);
                }
                return contactos;
            }
        }

        public override void aplicaCambios()
        {
            using (OleDbConnection Conn = new OleDbConnection(connectionString))
            {
                OleDbCommand cmdInsert = new OleDbCommand("INSERT INTO agenda.txt (id, nombre, apellido, email, telefono) VALUES (@id, @nombre, @apellido, @email, @telefono)", Conn);
                cmdInsert.Parameters.Add("@id", OleDbType.Integer);
                cmdInsert.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@email", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdUpdate = new OleDbCommand("UPDATE agenda.txt SET nombre=@nombre, apellido=@apellido, email=@email, telefono=@telefono WHERE id=@id", Conn);
                cmdUpdate.Parameters.Add("@id", OleDbType.Integer);
                cmdUpdate.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@email", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdDelete = new OleDbCommand("DELETE FROM agenda.txt WHERE id=@id", Conn);
                cmdDelete.Parameters.Add("@id", OleDbType.Integer);

                DataTable filasNuevas = this.misContactos.GetChanges(DataRowState.Added);
                DataTable filasBorradas = this.misContactos.GetChanges(DataRowState.Deleted);
                DataTable filasModificadas = this.misContactos.GetChanges(DataRowState.Modified);

                Conn.Open();

                if (filasNuevas != null)
                {
                    foreach (DataRow fila in filasNuevas.Rows)
                    {
                        cmdInsert.Parameters["@id"].Value = fila["id"];
                        cmdInsert.Parameters["@nombre"].Value = fila["nombre"];
                        cmdInsert.Parameters["@apellido"].Value = fila["apellido"];
                        cmdInsert.Parameters["@email"].Value = fila["email"];
                        cmdInsert.Parameters["@telefono"].Value = fila["telefono"];
                        cmdInsert.ExecuteNonQuery();
                    }
                }

                if (filasBorradas != null)
                {
                    foreach (DataRow fila in filasBorradas.Rows)
                    {
                        cmdDelete.Parameters["@id"].Value = fila["id", DataRowVersion.Original];
                        cmdDelete.ExecuteNonQuery();
                    }
                }

                if (filasModificadas != null)
                {
                    foreach (DataRow fila in filasModificadas.Rows)
                    {
                        cmdUpdate.Parameters["@id"].Value = fila["id"];
                        cmdUpdate.Parameters["@nombre"].Value = fila["nombre"];
                        cmdUpdate.Parameters["@apellido"].Value = fila["apellido"];
                        cmdUpdate.Parameters["@email"].Value = fila["email"];
                        cmdUpdate.Parameters["@telefono"].Value = fila["telefono"];
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
