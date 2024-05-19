using System.Windows.Forms;

namespace AcademiaABM
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario("001", "Juan","Gonzalez","Usuario 1", "usuario1@example.com", true),
            new Usuario("002", "Manuel","Garcia","Usuario 2", "usuario2@example.com", false),
            new Usuario("003", "Jose","Lopez","Usuario 3" ,"usuario3@example.com", true)
        };

            foreach (Usuario usuario in usuarios)
            {
                dgvUsuarios.Rows.Add(usuario.id, usuario.nombre, usuario.apellido, usuario.usuario, usuario.email, usuario.habilitado);
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {


            // Evitar que la DataGridView agregue columnas automáticamente
            dgvUsuarios.AutoGenerateColumns = false;

            // Definir las columnas manualmente
            dgvUsuarios.Columns.Add("id", "ID");
            dgvUsuarios.Columns.Add("nombre", "Nombre");
            dgvUsuarios.Columns.Add("apellido", "Apellido");
            dgvUsuarios.Columns.Add("usuario", "Usuario");
            dgvUsuarios.Columns.Add("email", "EMail");

            // Configurar el tipo de columna "habilitado" como CheckBox
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Habilitado";
            checkBoxColumn.Name = "habilitado";
            dgvUsuarios.Columns.Add(checkBoxColumn);

            // Configurar las propiedades de solo lectura para las columnas ID y Nombre
            dgvUsuarios.Columns["id"].ReadOnly = true;
            dgvUsuarios.Columns["nombre"].ReadOnly = true;

            Listar();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();

            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlUsuarios_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }


    class Usuario
    {
        public string id { get; }
        public string nombre { get; }
        public string apellido { get; }
        public string usuario { get; }
        public string email { get; }

        public bool habilitado { get; }

        public Usuario(string iid, string inombre, string iapellido, string iusuario, string iemail, bool ihabilitado)
        {
            id = iid;
            nombre = inombre;
            apellido = iapellido;
            usuario = iusuario;
            email = iemail;
            habilitado = ihabilitado;
        }
    }
}
