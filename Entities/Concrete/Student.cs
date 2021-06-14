using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Student:IEntity
    {
        public int Id { get; set; }
        public long TcIdentityNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthdayDate { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public long ParentPhoneNumber { get; set; }

    }
}
