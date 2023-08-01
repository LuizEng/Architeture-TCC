using ManagerService.Model.Entity;
using ManagerService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Service
{

    public class LoginService
    {
        private LoginRepository _loginRepository;
        public LoginService() 
        { 
            _loginRepository = new LoginRepository();
        }

        public Usuario getLogin(string usuario, string senha)
        {
            return _loginRepository.GetLogin(usuario, senha);
        }
    }
}
