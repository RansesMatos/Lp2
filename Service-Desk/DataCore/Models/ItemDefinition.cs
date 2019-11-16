using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataCore
{
    public class ItemDefinition
    
    {
        [Key]
        public int itemID { get; set; }
        [ForeignKey("SubCategoryDefinition")]
        public int subcategoryID { get; set; }
        public string name { get; set; }
    }
}
