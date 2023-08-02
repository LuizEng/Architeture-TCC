using ManagerService.Controller;
using ManagerService.Model.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerService.View
{
    public enum Acao
    {
        AcIncluindo,
        AcAlterando,
        AcNavegando
    }
    public partial class CadastroCliente_Form : Form
    {
        private Acao acao;
        private ClienteController clienteController;
        private List<ClienteDto> clientes;
        public CadastroCliente_Form()
        {
            InitializeComponent();            
            this.acao = Acao.AcNavegando;

            clienteController = new ClienteController();
            GetDadosCliente();
            grdDados.AutoGenerateColumns = true;            
        }        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetDadosCliente()
        {
            clientes = clienteController.RetornarTodosClienteDto();
            grdDados.DataSource = clientes;           
        }

        private void ControlarEstadoTela(Acao acao)
        {
            this.acao = acao;
            btnIncluir.Enabled = this.acao != Acao.AcIncluindo;
            
            btnAlterar.Enabled = this.acao != Acao.AcAlterando && this.clientes != null;

            btnExcluir.Enabled = this.acao == Acao.AcNavegando && this.clientes != null;

            btnCancelar.Visible = this.acao != Acao.AcNavegando;

            btnSalvar.Enabled = this.acao != Acao.AcNavegando;

            btnVoltar.Enabled = this.acao == Acao.AcNavegando;

            pnlControles.Enabled = this.acao != Acao.AcNavegando;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ControlarEstadoTela(Acao.AcIncluindo);
            txtNome.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {            
            if (GetIdSelecionado() > 0) {
                ControlarEstadoTela(Acao.AcAlterando);
                txtNome.Focus();
            }           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlarEstadoTela(Acao.AcNavegando);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.acao == Acao.AcIncluindo)
                this.clienteController.InserirCliente(txtNome.Text, txtTelefone.Text, txtEmail.Text);
            else if (this.acao == Acao.AcAlterando)
            {
                int id = GetIdSelecionado();
                if (id > 0)
                   this.clienteController.AtualizarCliente(id, txtNome.Text, txtTelefone.Text, txtEmail.Text);
            }

            ControlarEstadoTela(Acao.AcNavegando);
            GetDadosCliente();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = GetIdSelecionado();
            if (id > 0)
            {
                DialogResult result = MessageBox.Show("Deseja excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.clienteController.RemoverCliente(id);
                    GetDadosCliente();
                }
                
            }
        }

        private int GetIdSelecionado()
        {
            int id = 0;
            if (grdDados.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grdDados.SelectedRows[0];
                id = (int)selectedRow.Cells["Id"].Value;
            }
            
            if (id ==0)
            {
                MessageBox.Show("Selecione um item na grid para executar esta ação");
            }

            return id;
                
        }

        private void grdDados_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDados.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grdDados.SelectedRows[0];

                txtNome.Text = selectedRow.Cells["Nome"].Value.ToString(); ;
                txtTelefone.Text = selectedRow.Cells["Telefone"].Value.ToString(); ;
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString(); ;
            }
        }
    }
}
