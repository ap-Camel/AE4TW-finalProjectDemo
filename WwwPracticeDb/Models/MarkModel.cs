using System;
using System.Collections.Generic;
using System.Text;

namespace WwwPracticeDb.Models
{
    public class MarkModel
    {
        public int markID { get; set; }
        public float mark { get; set; }
        public int examID { get; set; }
        public int studentID { get; set; }

    }
}
