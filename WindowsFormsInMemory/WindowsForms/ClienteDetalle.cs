using Domain.Model;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
