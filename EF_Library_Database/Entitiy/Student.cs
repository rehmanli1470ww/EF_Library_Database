using EF_Library_Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Library_Database.Entitiy
{
    public class Student : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? SchoolNumber { get; set; }
        public Gender gender { get; set; }

        public DateTime BrithDay { get; set; }
        public string? PhoneNumber { get; set; }

        public ICollection <Book> ?Books{ get; set; }
    }
}
