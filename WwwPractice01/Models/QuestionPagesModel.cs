using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WwwPractice01.Models
{
    public class QuestionPagesModel
    {
        public int questionID { get; set; }
        public string question { get; set; }
        public string Canswer { get; set; }
        public string Wanswer01 { get; set; }
        public string Wanswer02 { get; set; }
        public string Wanswer03 { get; set; }
        public int examID { get; set; }
    }
}
