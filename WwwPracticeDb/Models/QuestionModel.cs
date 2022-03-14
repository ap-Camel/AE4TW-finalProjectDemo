using System;
using System.Collections.Generic;
using System.Text;

namespace WwwPracticeDb.Models
{
    public class QuestionModel
    {
        public int questionID { get; set; }
        public string question { get; set; }
        public string Canswer { get; set; }
        public string Ranswer01 { get; set; }
        public string Ranswer02 { get; set; }
        public string Ranswer03 { get; set; }
        public int teacherID { get; set; }
    }
}
