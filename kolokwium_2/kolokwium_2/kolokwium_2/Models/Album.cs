using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium_2.Models
{
    public class Album
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdAlbum { get; set; }

        [MaxLength(200)]
        public string AlbumName { get; set; }

        [MaxLength(40)]
        public string PublishDate { get; set; }

        public float IdMusicLabel { get; set; }

    }
}
