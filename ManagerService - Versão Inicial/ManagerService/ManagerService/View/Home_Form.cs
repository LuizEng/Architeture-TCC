using ManagerService.Controller;
using ManagerService.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerService.View
{
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            ClienteController clienteController = new ClienteController();
            grdClientes.DataSource = clienteController.RetornarTodosClientes();

            AgendaController agendaController = new AgendaController();
            grdDadosHoje.DataSource = agendaController.GetAgendaHoje();

            grdDadosSemana.DataSource = agendaController.GetAgendaSemana();
        }

        private void Home_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroCliente_Form cadastroCliente_Form  = new CadastroCliente_Form();
            cadastroCliente_Form.ShowDialog();
            this.Show();
        }
    }
}
