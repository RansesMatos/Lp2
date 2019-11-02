using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataCore
{
    public class WorkOrder
    {
        [Key] 
        public int workOrderID { get; set; }
        [ForeignKey("Request")]
        public int requesterID { get; set; }
        [ForeignKey("")]
        public int createdByID { get; set; }
        public DateTime createdTime { get; set; }
        public DateTime respondedTime { get; set; }
        public DateTime dueTime { get; set; }
        public DateTime lastUpdate { get; set; }
        public DateTime completedTime { get; set; }
        public int TimeSpentOn { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [ForeignKey("Mode")]
        public int modeID { get; set; }
        [ForeignKey("Department")]
        public int departmentID { get; set; }
        public DateTime fr_DueTime { get; set; }

    }
}
