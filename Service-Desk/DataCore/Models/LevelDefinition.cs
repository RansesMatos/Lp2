using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class LevelDefinition
    {
        [Key]
        public int levelId { get; set; }
        public string levelName { get; set; }
    }
}
