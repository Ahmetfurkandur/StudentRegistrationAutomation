using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfLoginDal:EfRepositoryBase<Person,SchoolDBContext>,ILoginDal
    {

    }
}
