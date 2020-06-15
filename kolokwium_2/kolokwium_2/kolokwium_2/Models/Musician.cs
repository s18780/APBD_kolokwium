using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium_2.Models
{
    public class Musician
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdMusician { get; set; }

    
        public string FirstName { get; set; }

       
        public string LastName { get; set; }
        
        public string NickName { get; set; }


    }
}

