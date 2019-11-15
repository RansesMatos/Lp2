using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class ComponentDefinition
    {
        [Key]
        public int componentID { get; set; }
        public string componentName { get; set; }
        public string manufacturerName { get; set; }
        public int partNo { get; set; }
        public string comments { get; set; }
        public int warrantyPeriod { get; set; }
        public string productCode { get; set; }
        public int unitPrice { get; set; }
    }
}
