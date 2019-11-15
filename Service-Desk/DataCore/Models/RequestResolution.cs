using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class RequestResolution
    {
        [Key]
        public int requestID { get; set; }
        [MaxLength(50)]
        public string resolution { get; set; }
    }
}
