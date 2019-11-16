using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class ServiceContract
    {
        [Key]
        public int contractID { get; set; }
        public string contractName { get; set; }
    }
}
