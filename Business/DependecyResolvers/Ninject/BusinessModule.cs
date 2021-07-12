using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;
using Ninject.Modules;

namespace Business.DependecyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IStudentService>().To<StudentManager>();
            Bind<ILoginService>().To<LoginManager>();
            Bind<IStudentDal>().To<EfStudentDal>();
            Bind<ILoginDal>().To<EfLoginDal>();
        }
    }
}
