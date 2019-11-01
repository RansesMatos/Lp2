using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class ModeDefinition
    {
        [Key]
        public int modeID { get; set; }
        [MaxLength(100)]
        public string modeName { get; set; }
    }
}
