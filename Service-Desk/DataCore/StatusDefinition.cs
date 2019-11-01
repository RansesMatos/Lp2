using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class StatusDefinition
    {
        [Key]
        private int statusID { get; set; }
        [MaxLength(100)]
        private string statusName { get; set; }
    }
}
