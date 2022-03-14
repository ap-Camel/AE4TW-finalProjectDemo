using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WwwPractice01.Models
{
    public class ExamPagesModel
    {
        public int examID { get; set; }
        public string title { get; set; }
        public string status { get; set; }
        public int teacherID { get; set; }
    }
}
