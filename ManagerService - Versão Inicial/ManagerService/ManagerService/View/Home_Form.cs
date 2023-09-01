using ManagerService.Controller;
using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
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
        private int idUsuarioLogado;

        public Home_Form(int UsarioLogado)
        {
            InitializeComponent();
            this.idUsuarioLogado = UsarioLogado;
            CarregarDados();
        }

        private void CarregarDados()
        {
            ClienteController clienteController = new ClienteController();
            grdClientes.DataSource = clienteController.RetornarTodosClientes();
            grdClientes.Refresh();

            AgendaController agendaController = new AgendaController();
            grdDadosHoje.DataSource = agendaController.GetAgendaHoje();
            grdDadosHoje.Refresh();

            grdDadosSemana.DataSource = agendaController.GetAgendaSemana();
            grdDadosHoje.Refresh();
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
            CadastroServico_Form cadastroServico_Form = new CadastroServico_Form(idUsuarioLogado);
            cadastroServico_Form.ShowDialog();
            CarregarDados();
            this.Show();
        }

        private void agendarServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento_Form agendamento = new Agendamento_Form(0);
            agendamento.ShowDialog();
            CarregarDados();
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
            CarregarDados();
        }

        private void grdDadosHoje_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && grdDadosHoje.Rows.Count > 0)
            {
                var hitTestInfo = grdDadosHoje.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    grdDadosHoje.ClearSelection();
                    grdDadosHoje.Rows[hitTestInfo.RowIndex].Selected = true;
                    Rectangle cellRectangle = grdDadosHoje.GetCellDisplayRectangle(hitTestInfo.ColumnIndex, hitTestInfo.RowIndex, true);

                    mnuAgenda.Show(grdDadosHoje, cellRectangle.Left + e.X, cellRectangle.Top + e.Y);
                }

            }
        }

        private void realizarPagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pagamento_Form pagamento_Form = new Pagamento_Form((int)grdDadosHoje.SelectedRows[0].Cells[0].Value);
            pagamento_Form.ShowDialog();
        }
    }
}
