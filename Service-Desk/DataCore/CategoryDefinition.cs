using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class CategoryDefinition
    {
        [Key]
        private int categoryID { get; set; }
        [MaxLength(100)]
        private string categoryName { get; set; }

    }
}
