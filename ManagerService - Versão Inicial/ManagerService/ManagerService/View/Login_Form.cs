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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();

            Usuario usuario = loginController.RealizarLogin(txtLogin.Text, txtSenha.Text);

            if (usuario != null)
            {
                this.Hide();
                Home_Form home_Form = new Home_Form(usuario.Id);
                home_Form.Show();                
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
