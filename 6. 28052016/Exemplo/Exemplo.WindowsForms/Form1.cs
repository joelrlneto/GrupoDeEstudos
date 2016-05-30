using Exemplo.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo.WindowsForms
{
    public partial class Form1 : Form
    {
        private List<Cliente> clientes;

        public Form1()
        {
            InitializeComponent();
            clientes = RepositorioClientes.Clientes;
            gridClientes.DataSource = clientes;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente selecionado = gridClientes.SelectedRows[0].DataBoundItem as Cliente;
            clientes.Remove(selecionado);
            gridClientes.DataSource = null;
            gridClientes.DataSource = clientes;
        }
    }
}
