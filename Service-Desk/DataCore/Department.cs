using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class Department
    {   [Key]
        private int departmentID { get; set; }
        [MaxLength(100)]
        private string departmentName { get; set; }
    }
}
