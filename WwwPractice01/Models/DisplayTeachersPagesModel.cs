using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WwwPractice01.Models
{
    public class DisplayTeachersPagesModel
    {
        
        public string PersonID { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "First name is too long")]
        [MinLength(3, ErrorMessage = "Firs tname too long")]
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
