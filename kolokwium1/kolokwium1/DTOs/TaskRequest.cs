using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium1.DTOs
{
    public class TaskRequest
    {
        [Required]
        public string idProject { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string deadline { get; set; }
        
    }
}
