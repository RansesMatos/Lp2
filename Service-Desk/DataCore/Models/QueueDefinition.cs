﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    class QueueDefinition
    {
        [Key]
        public int queueID { get; set; }
        [MaxLength(50)]
        public string queueName { get; set; }

    }
}
