using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class PriorityDefinition
    {
        [Key]
        public int priorityID { get; set; }
        public string priorityName { get; set; }
    }
}
