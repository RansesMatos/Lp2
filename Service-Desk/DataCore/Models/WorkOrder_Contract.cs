using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataCore
{
    public class WorkOrder_Contract
    {
        public int workorderID { get; set; }
        [ForeignKey("ServiceContract")]
        public int contractID { get; set; }
    }
}
