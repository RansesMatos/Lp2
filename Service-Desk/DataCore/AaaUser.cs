using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class AaaUser
    {
        [Key]
        public int userID { get; set; }
        public string firstName { get; set; }
    }
}
