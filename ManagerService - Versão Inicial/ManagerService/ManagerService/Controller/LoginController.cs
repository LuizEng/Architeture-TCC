using ManagerService.Model.Entity;
using ManagerService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Controller
{
    public class LoginController
    {
        private LoginService LoginService;

        public LoginController() 
        {
            LoginService = new LoginService();
        }    

        public Boolean RealizarLogin(string usuario, string senha)
        {
            Usuario user = LoginService.getLogin(usuario, senha);
            return user != null;
        }
    }
}
