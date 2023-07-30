using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager01
{
    public partial class Atendimento_Form : Form
    {
        public Atendimento_Form()
        {
            InitializeComponent();
        }

        private void btnIniciarAtendimento_Click(object sender, EventArgs e)
        {
            this.Hide();
            AtendimentoDados_Form atendimentoDados_Form = new AtendimentoDados_Form();            
            atendimentoDados_Form.ShowDialog();
            this.Show();
        }

        private void btnAlterarAtendimento_Click(object sender, EventArgs e)
        {
            this.Hide();
            AtendimentoDados_Form atendimentoDados_Form = new AtendimentoDados_Form();            
            atendimentoDados_Form.ShowDialog();
            this.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Caixa_Form caixa_Form = new Caixa_Form();
            caixa_Form.ShowDialog();
            this.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
