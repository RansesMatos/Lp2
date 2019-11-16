using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class Department
    {   
        [Key]
        public int departmentID { get; set; }
        [MaxLength(100)]
        public string departmentName { get; set; }
    }
}
