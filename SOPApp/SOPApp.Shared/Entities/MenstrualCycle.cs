using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOPApp.Shared.Entities
{
    public class MenstrualCycle
    {
        [Required (ErrorMessage ="El campo {0} es obligatorio")]
        public DateTime StartTime { get; set; }
        [Required (ErrorMessage ="El campo {0} es obligatorio")]
        public DateTime EndTime { get; set; }

    }
}
