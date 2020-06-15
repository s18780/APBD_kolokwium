using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium_2.Models
{
    public class MusicianTrack
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdMusicianTrack { get; set; }

        public int IdTrack { get; set; }
  
        public int IdMusician { get; set; }

        public float IdMusicLabel { get; set; }

    }
}
