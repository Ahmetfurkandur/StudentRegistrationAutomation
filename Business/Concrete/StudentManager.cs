using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager:IStudentService
    {
        private IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll().ToList();
        }

        public List<Student> GetStudentsByStudentName(string studentName)
        {
            return _studentDal.GetAll(s=> s.Name.Contains(studentName));
        }

        public List<Student> GetStudentsByTcIdentityNo(long tcIdentityNo)
        {
            return _studentDal.GetAll(s=> s.TcIdentityNo==tcIdentityNo);
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }
    }
}
