using System;
using System.Collections.Generic;
using System.Text;

namespace DataCore
{
    public class ComponentDefinition
    {
        private int componentID { get; set; }
        private string componentName { get; set; }
        private string manufacturerName { get; set; }
        private int partNo { get; set; }
        private string comments { get; set; }
        private int warrantyPeriod { get; set; }
        private string productCode { get; set; }
        private int unitPrice { get; set; }
    }
}
