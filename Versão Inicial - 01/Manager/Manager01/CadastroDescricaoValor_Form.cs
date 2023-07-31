using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager01
{
    enum TipoAcao
    {
        taIncluindo,
        taAlterando,
        taBrowse
    }
    public enum TipoCadastro
    {
        tcServico,
        tcAtendimento,
        tcPagamento
    }

    public partial class CadastroDescricaoValor_Form : Form
    {
        private TipoCadastro tipoCadastro;
        private MySqlDataAdapter dataAdapter;
        private BindingSource bindingSourceCadastro = new BindingSource();
        private DataSet dataSet = new DataSet();
        private String tabela;
        private TipoAcao tipoAcao;

        public CadastroDescricaoValor_Form(TipoCadastro tipoCadastro)
        {
            InitializeComponent();
            this.tipoCadastro = tipoCadastro;
            setDataAdapter();
            this.tipoAcao = TipoAcao.taBrowse;
        }

        private void setDataAdapter()
        {
            SqlController sqlController = new SqlController();            
            switch (tipoCadastro)
            {
                case TipoCadastro.tcServico:
                    dataAdapter = sqlController.GetDataAdapter("SELECT * FROM servico");
                    tabela = "servico";
                    break;

                case TipoCadastro.tcPagamento:
                    dataAdapter = sqlController.GetDataAdapter("SELECT * FROM tipo_pagamento");
                    tabela = "tipo_pagamento";
                    break;

                case TipoCadastro.tcAtendimento:
                    dataAdapter = sqlController.GetDataAdapter("SELECT * FROM tipo_atendimento");
                    tabela = "tipo_atendimento";
                    break;

                default:
                    
                    break;
            }
            dataSet.Clear();
            grdDados.AutoGenerateColumns = true;
            dataAdapter.Fill(dataSet, tabela);                
            bindingSourceCadastro.DataSource = dataSet.Tables[tabela];
            grdDados.DataSource = bindingSourceCadastro;
            txtValor.Visible = this.tipoCadastro == TipoCadastro.tcServico;
            lblValor.Visible = this.tipoCadastro == TipoCadastro.tcServico;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            this.tipoAcao = TipoAcao.taIncluindo;
            setEstadoCampos(true, true);
        }

        private void setEstadoCampos(Boolean ativo, Boolean limparCampos)
        {
            txtValor.Enabled = ativo;
            txtDescricao.Enabled = ativo;         
            if (limparCampos)
            {
                txtValor.Text = string.Empty; 
                txtDescricao.Text = string.Empty;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.tipoAcao = TipoAcao.taAlterando;
            setEstadoCampos(true, false);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (this.tipoAcao == TipoAcao.taBrowse)
                this.Close();
            else
            {
                this.tipoAcao = TipoAcao.taBrowse;
                setEstadoCampos(false, true);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {            
            Salvar();
            this.tipoAcao = TipoAcao.taBrowse;
            setEstadoCampos(false, true);            
            setDataAdapter();
        }

        private Boolean Salvar()
        {
            if (!ValidarCampos())
            {
                return false;
            }
            if (this.tipoAcao == TipoAcao.taIncluindo)
            {
                string insert;
                if (tipoCadastro == TipoCadastro.tcServico)
                {
                    insert = "INSERT INTO "+tabela+" (descricao, valor) VALUES ('"+txtDescricao.Text+"', '"+txtValor.Text+"')";
                }
                else
                {
                    insert = "INSERT INTO "+tabela+" (descricao) VALUES ('" + txtDescricao.Text + "')";
                }
                SqlController sqlController = new SqlController();
                sqlController.ExecSql(insert);
            }
            else if (this.tipoAcao == TipoAcao.taAlterando)
            {
                string campoValor = "";
                if (tipoCadastro == TipoCadastro.tcServico)
                {
                    campoValor = ", valor = " + txtValor.Text;
                }

                DataGridViewRow linhaSelecionada = grdDados.SelectedRows[0];
                string id = linhaSelecionada.Cells["id"].Value.ToString();
                
                string update = "UPDATE "+tabela+" SET descricao = '"+txtDescricao.Text+"' "+ campoValor + " WHERE ID = "+ id;

                SqlController sqlController = new SqlController();
                sqlController.ExecSql(update);
            }

            return true;
        } 

        private Boolean ValidarCampos()
        {
            if (txtValor.Visible)
            {
                if (txtValor.Text.Length == 0)
                {
                    MessageBox.Show("O Campo Valor não pode ser vazio!");
                    return false;
                }                
            }

            if (txtDescricao.Text.Length == 0)
            {
                MessageBox.Show("O Campo Descrição não pode ser vazio!");
                return false;
            }
            return true;
        }

        private void grdDados_SelectionChanged(object sender, EventArgs e)
        {
            if (tipoAcao == TipoAcao.taBrowse)
            {
                DataGridView dataGridView = (DataGridView)sender;
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                    if (txtValor.Visible)
                    {
                        txtValor.Text = selectedRow.Cells["valor"].Value.ToString().Replace(",", ".");
                    }

                    txtDescricao.Text = selectedRow.Cells["descricao"].Value.ToString();
                }
            }

        }
    }
}
