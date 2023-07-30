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
    public partial class Manager_Form : Form
    {
        public Manager_Form()
        {
            InitializeComponent();
        }

        private void btnAtendimentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atendimento_Form atendimento_form = new Atendimento_Form();
            atendimento_form.ShowDialog();
            this.Show();
        }

        private void Manager_Form_FormClosed(object sender, FormClosedEventArgs e)
        {            
            Application.Exit();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Caixa_Form caixa_form = new Caixa_Form();
            caixa_form.ShowDialog();
            this.Show();
        }
    }
}
