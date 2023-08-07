using ManagerService.Controller;
using ManagerService.Model.Dto;
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
            CarregarDados();
            this.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroServico_Form cadastroServico_Form = new CadastroServico_Form();
            cadastroServico_Form.ShowDialog();
            CarregarDados();
            this.Show();
        }

        private void agendarServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento_Form agendamento = new Agendamento_Form(0);
            agendamento.ShowDialog();
        }

        private void grdClientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && grdClientes.Rows.Count > 0)
            {
                var hitTestInfo = grdClientes.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    grdClientes.ClearSelection();
                    grdClientes.Rows[hitTestInfo.RowIndex].Selected = true;
                    Rectangle cellRectangle = grdClientes.GetCellDisplayRectangle(hitTestInfo.ColumnIndex, hitTestInfo.RowIndex, true);

                    mnuAgendar.Show(grdClientes, cellRectangle.Left + e.X, cellRectangle.Top + e.Y);                 
                }
                
            }
        }

        private void agendarServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteController clienteController = new ClienteController();
            ClienteDto cliente = clienteController.GetByNome(grdClientes.SelectedRows[0].Cells[0].Value.ToString());

            Agendamento_Form agendamento = new Agendamento_Form(cliente.Id);
            agendamento.ShowDialog();
        }
    }
}
