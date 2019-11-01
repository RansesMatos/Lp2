using System;
using System.Collections.Generic;
using System.Text;

namespace DataCore
{
    public class WorkOrderStates
    {
        private int workOrderID { get; set; }
        private int categoryID { get; set; }
        private int subcategoryID { get; set; }
        private int itemID { get; set; }
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
