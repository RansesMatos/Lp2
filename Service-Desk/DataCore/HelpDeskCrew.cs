using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataCore
{
    public class HelpDeskCrew
    {
        [Key]
        public int technicianID { get; set; }
        public int costperHour { get; set; }
        public string extension { get; set; }

    }
}
