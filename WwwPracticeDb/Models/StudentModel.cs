using System;
using System.Collections.Generic;
using System.Text;

namespace WwwPracticeDb.Models
{
    public class StudentModel
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
