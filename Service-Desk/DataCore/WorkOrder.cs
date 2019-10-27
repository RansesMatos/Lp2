using System;

namespace DataCore
{
    public class WorkOrder
    {
        private int workOrderID { get; set; }
        private int requesterID { get; set; }
        private int createdByID { get; set; }
        private DateTime createdTime { get; set; }
        private DateTime respondedTime { get; set; }
        private DateTime dueTime { get; set; }
        private DateTime lastUpdate { get; set; }
        private DateTime completedTime { get; set; }
        private int TimeSpentOn { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int modeID { get; set; }
        private int departmentID { get; set; }
        private DateTime fr_DueTime { get; set; }

    }
}
