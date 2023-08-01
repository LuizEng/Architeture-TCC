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
            if (loginController.RealizarLogin(txtLogin.Text, txtSenha.Text))
            {

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }
    }
}
