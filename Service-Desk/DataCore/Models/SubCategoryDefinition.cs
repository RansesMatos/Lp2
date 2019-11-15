using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataCore
{
    public class SubCategoryDefinition
    {
        [Key]
        public int subcategoryID { get; set; }
        [ForeignKey("CategoryDefinition")]
        public int categoryID { get; set; }
        public string name { get; set; }
    }
}
