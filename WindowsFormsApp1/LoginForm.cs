using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using Business.DependecyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            _loginService = InstanceFactory.GetInstance<ILoginService>();
        }
        ILoginService _loginService;
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = tbxUsername.Text;
            var password = tbxPassword.Text;
            var errorMessage = "";
            var isError = false;

            if (string.IsNullOrEmpty(username))
            {
                errorMessage += "Kullanıcı Adı Boş Bırakılamaz!\r\n";
                isError = true;
            }

            if (string.IsNullOrEmpty(password))
            {
                errorMessage += "Şifre Boş Bırakılamaz!\r\n";
                isError = true;
            }

            if(isError)
                MessageBox.Show(errorMessage,"Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);

            var loginState = _loginService.Login(username,password);

            if (loginState)
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                int right = 5;

                MessageBox.Show("Giriş Başarısız Lütfen Tekrar Deneyiniz");
                right--;
                if (right<0)
                {
                    this.Close();
                }
            }

        }

        
    }
}
