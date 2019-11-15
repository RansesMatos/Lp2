using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class StatusDefinition
    {
        [Key]
        public int statusID { get; set; }
        [MaxLength(100)]
        public string statusName { get; set; }
    }
}
