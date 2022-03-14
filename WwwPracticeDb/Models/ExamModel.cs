using System;
using System.Collections.Generic;
using System.Text;

namespace WwwPracticeDb.Models
{
    public class ExamModel
    {
        public int examID { get; set; }
        public string title { get; set; }
        public string status { get; set; }
        public int teacherID { get; set; }
    }
}
