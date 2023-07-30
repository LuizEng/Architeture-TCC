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
    public partial class Caixa_Form : Form
    {
        public Caixa_Form()
        {
            InitializeComponent();
        }

        private void btnPagarAtendimento_Click(object sender, EventArgs e)
        {
            this.Hide();
            ValoresCaixa_Form valoresCaixa_Form = new ValoresCaixa_Form();
            valoresCaixa_Form.ShowDialog();
            this.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
