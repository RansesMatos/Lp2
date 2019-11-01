using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    class QueueDefinition
    {
        [Key]
        private int queueID { get; set; }
        [MaxLength(50)]
        private string queueName { get; set; }

    }
}
