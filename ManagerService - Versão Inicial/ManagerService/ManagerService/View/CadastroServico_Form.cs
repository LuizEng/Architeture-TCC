using ManagerService.Controller;
using ManagerService.Model.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerService.View
{
    public partial class CadastroServico_Form : Form
    {
        private Acao acao;

        private ServicoController servicoController;
        private List<ServicoDto> servicos;
        public CadastroServico_Form()
        {
            InitializeComponent();
            this.acao = Acao.AcNavegando;

            servicoController = new ServicoController();            
            grdDados.AutoGenerateColumns = true;

            GetDadosServico();
        }

        private void GetDadosServico()
        {
            servicos = servicoController.RetornarServicosDto();
            grdDados.DataSource = servicos;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e) => this.Close();

        private void ControlarEstadoTela(Acao acao)
        {
            this.acao = acao;
            btnIncluir.Enabled = this.acao != Acao.AcIncluindo;

            btnAlterar.Enabled = this.acao != Acao.AcAlterando; //&& this.clientes != null;

            btnExcluir.Enabled = this.acao == Acao.AcNavegando; //&& this.clientes != null;

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

        private int GetIdSelecionado()
        {
            int id = 0;
            if (grdDados.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grdDados.SelectedRows[0];
                id = (int)selectedRow.Cells["Id"].Value;
            }

            if (id == 0)
            {
                MessageBox.Show("Selecione um item na grid para executar esta ação");
            }

            return id;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (GetIdSelecionado() > 0)
            {
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
            {                
                servicoController.IncluirServico(txtNome.Text, float.Parse(txtValor.Text, CultureInfo.InvariantCulture), float.Parse(txtCustoMedio.Text, CultureInfo.InvariantCulture));
            }
            else if (this.acao == Acao.AcAlterando)
            {
                int id = GetIdSelecionado();
                if (id > 0)
                    servicoController.AtualizarServico(id, txtNome.Text, float.Parse(txtValor.Text, CultureInfo.InvariantCulture), float.Parse(txtCustoMedio.Text, CultureInfo.InvariantCulture));
            }

            ControlarEstadoTela(Acao.AcNavegando);
            GetDadosServico();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = GetIdSelecionado();
            if (id > 0)
            {
                DialogResult result = MessageBox.Show("Deseja excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    servicoController.ExcluirServico(id);
                    GetDadosServico();
                }
            }
        }

        private void grdDados_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDados.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grdDados.SelectedRows[0];

                txtNome.Text = selectedRow.Cells["Descricao"].Value.ToString(); 
                txtValor.Text = selectedRow.Cells["Valor"].Value.ToString().Replace(",", "."); 
                txtCustoMedio.Text = selectedRow.Cells["Valor"].Value.ToString().Replace(",", ".");
            }
        }
    }
}
