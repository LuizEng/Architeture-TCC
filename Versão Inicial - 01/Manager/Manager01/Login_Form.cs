using MySql.Data.MySqlClient;
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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            SqlController sqlReader = new SqlController();
            MySqlDataReader reader = sqlReader.GetDataReader("SELECT 1 FROM usuario WHERE nome = '" + txtLogin.Text + "' AND token='" + txtSenha.Text + "'");
            if (reader.HasRows)
            {
                this.Hide();
                Manager_Form manager_Form = new Manager_Form();
                manager_Form.Show();                
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogar_Click(sender, e);
            }
        }
    }
}
