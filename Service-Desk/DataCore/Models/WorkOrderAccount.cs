using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataCore
{
    public class WorkOrderAccount
    {
        [ForeignKey("WorkOrder")]
        public int workorderID { get; set; }
        [ForeignKey("AaaOrganization")]
        public int accountID { get; set; }
        [ForeignKey("AaaOrganization")]
        public int subaccountID { get; set; }
    }
}
