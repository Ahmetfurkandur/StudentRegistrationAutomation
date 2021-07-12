using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LoginManager:ILoginService
    {
        ILoginDal _loginDal;
        public LoginManager(ILoginDal loginDal)
        {
            _loginDal = loginDal;
        }

        public bool Login(string username,string password)
        {
            return _loginDal.Login(username,password);
        }
    }
}
