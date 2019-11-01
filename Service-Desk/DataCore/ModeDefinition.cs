using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class ModeDefinition
    {
        [Key]
        private int modeID { get; set; }
        [MaxLength(100)]
        private string modeName { get; set; }
    }
}
