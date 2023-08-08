using ManagerService.Controller;
using ManagerService.Model.Entity;
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
    public partial class Pagamento_Form : Form
    {
        private int agenda;
        private PagamentoController pagamentoController;
        public Pagamento_Form(int idAgenda)
        {
            InitializeComponent();
            this.agenda = idAgenda;
            pagamentoController = new PagamentoController();
            List<string> lista = new List<string>();           
            cmbTipoPagamento.DataSource = pagamentoController.GetTiposPagamentos();
            CalcularValores();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            pagamentoController.RealizarPagamentoAsync(agenda, cmbTipoPagamento.SelectedIndex + 1, float.Parse(txtValor.Text));
            CalcularValores();
        }

        public void CalcularValores()
        {
            float valorPago = pagamentoController.GetValorPago(this.agenda);
            AgendaController agendaController = new AgendaController();
            float valorTotal = agendaController.GetValorServicos(this.agenda);

            lblTotalPago.Text = "R$" + valorPago.ToString();
            lblTotalServicos.Text = "R$" + valorTotal.ToString();
            lblSaldo.Text = "R$" + (valorTotal - valorPago).ToString();
            txtValor.Text = (valorTotal - valorPago).ToString();
        }
    }
}
