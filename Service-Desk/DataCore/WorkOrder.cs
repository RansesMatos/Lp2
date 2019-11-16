using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataCore
{
    public class WorkOrder
    {
        [Key] 
        private int workOrderID { get; set; }
        [ForeignKey]
        private int requesterID { get; set; }
        [ForeignKey]
        private int createdByID { get; set; }
        private DateTime createdTime { get; set; }
        private DateTime respondedTime { get; set; }
        private DateTime dueTime { get; set; }
        private DateTime lastUpdate { get; set; }
        private DateTime completedTime { get; set; }
        private int TimeSpentOn { get; set; }
        [StringLength(50)]
        private string Title { get; set; }
        [StringLength(150)]
        private string Description { get; set; }
        [ForeignKey]
        private int modeID { get; set; }
        [ForeignKey]
        private int departmentID { get; set; }
        private DateTime fr_DueTime { get; set; }

    }
}
