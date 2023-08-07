using Google.Protobuf.Reflection;
using ManagerService.Controller;
using ManagerService.Converter;
using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerService.View
{
    public partial class Agendamento_Form : Form
    {
        private int idCliente;
        private List<ClienteDto> clientes;
        private List<ServicoDto> servicos;
        public Agendamento_Form(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            AlimentarClientes();
            AlimentarServicos();
        }

        private void AlimentarClientes()
        {
            ClienteController clienteController = new ClienteController();  
            if (this.idCliente > 0)
            {                                
                clientes = new List<ClienteDto>
                {
                    clienteController.RetornarClientePorIdDto(this.idCliente)
                };
            }
            else
            {
                clientes = clienteController.RetornarTodosClienteDto();
            }

            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.Enabled = this.idCliente == 0;
        }

        private void AlimentarServicos()
        {
            ServicoController servicoController = new ServicoController();
            servicos = servicoController.RetornarServicosDto();
            servicos.ForEach(x => clbServicos.Items.Add(x.Descricao));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
                this.Close();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {            
            DialogResult result = MessageBox.Show("Deseja realizar o agendamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {                
                ClienteDto cliente = clientes.Find(p => p.Nome == cmbCliente.Text);
                if (cliente != null)
                {
                    List<int> servicos = new List<int>();
                    for (int i = 0; i < clbServicos.Items.Count; i++)
                    {
                        if (clbServicos.GetItemChecked(i))
                        {
                            ServicoDto servico = this.servicos.Find(s => s.Descricao == clbServicos.Items[i].ToString());
                            servicos.Add(servico.Id);
                        }
                    }

                    if (servicos.Count > 0)
                    {
                        AgendaController agendaController = new AgendaController();
                        float hora = float.Parse(txtHora.Text.Replace(":", ","));
                        agendaController.IncluirAgenda(cliente.Id, mcData.SelectionRange.Start, hora, servicos);
                        MessageBox.Show("Agenda marcada com sucesso!");
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Nenhum serviço foi selecionado!");
                }
                else
                    MessageBox.Show("Nenhum cliente foi selecionado!");
            }
        }

        private string RemoveCaracteresInvalidos(string input)
        {
            string result = "";
            int maxLength = 5;

            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == ':')
                {
                    result += c;
                }
            }
            if (result.Length > maxLength)
            {
                result = result.Substring(0, maxLength);
            }

            return result;
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
