using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataCore
{
    public class WorkOrderStates
    {
        [Key]
        private int workOrderID { get; set; }
        [ForeignKey]
        private int categoryID { get; set; }
        [ForeignKey]
        private int subcategoryID { get; set; }
        [ForeignKey]
        private int itemID { get; set; }
        [ForeignKey]
        private int ownerID { get; set; }
        private DateTime assignedTime { get; set; }
        private int statusID { get; set; }
        private int levelID { get; set; }
        private bool isOverdue { get; set; }
        private bool isEscalated { get; set; }
        private bool isfrOverdue { get; set; }
        private string resolution_Comments { get; set; }
    }
}
