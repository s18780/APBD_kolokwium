using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium_2.Models
{
    public class Track
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdTrack { get; set; }

        [MaxLength(200)]
        public string TrackName { get; set; }

        
        public float Duration { get; set; }

        public float IdMusicLabel { get; set; }
    }
}
