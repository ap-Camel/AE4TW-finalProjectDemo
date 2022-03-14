using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WwwPractice01.Models
{
    public class StudentPagesModel
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string userID { get; set; }
        public int teacherID { get; set; }
    }
}
