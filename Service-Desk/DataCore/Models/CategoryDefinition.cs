using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class CategoryDefinition
    {
        [Key]
        public int categoryID { get; set; }
        [MaxLength(100)]
        public string categoryName { get; set; }

    }
}
