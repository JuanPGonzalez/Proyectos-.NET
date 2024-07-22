using basededatos;
using Domain.Services;

namespace WindowsForms
{
    public partial class ClienteDetalle : Form
    {
        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set 
            { 
                cliente = value;
                this.SetCliente();
            }
        }

        public bool EditMode { get; set; } = false;

        public ClienteDetalle()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();

            if (this.ValidateCliente())
            {
                this.Cliente.Nombre = nombreTextBox.Text;

                if (this.EditMode)
                {
                    clienteService.Update(this.Cliente);
                }
                else
                {
                    clienteService.Add(this.Cliente);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetCliente()
        {
            this.nombreTextBox.Text = this.Cliente.Nombre;
        }

        private bool ValidateCliente()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }

            return isValid;
        }

 
    }
}
