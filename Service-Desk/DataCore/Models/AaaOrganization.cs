using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class AaaOrganization
    {
        [Key]
        public int orgID { get; set; }
        public string name { get; set; }
    }
}
