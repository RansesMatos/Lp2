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
        public int workOrderID { get; set; }
        [ForeignKey("")]
        public int categoryID { get; set; }
        [ForeignKey("")]
        public int subcategoryID { get; set; }
        [ForeignKey("")]
        public int itemID { get; set; }
        [ForeignKey("")]
        public int ownerID { get; set; }
        public DateTime assignedTime { get; set; }
        public int statusID { get; set; }
        public int levelID { get; set; }
        public bool isOverdue { get; set; }
        public bool isEscalated { get; set; }
        public bool isfrOverdue { get; set; }
        public string resolution_Comments { get; set; }
    }
}
