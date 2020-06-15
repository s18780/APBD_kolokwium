using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace kolokwium_2.DTOs
{
    public class albumyDTO
    {
        [JsonProperty("idalbum")]
        public int idAlbum { get; set; }
        [JsonProperty("albumName")]
        public string albumName { get; set; }
        [JsonProperty("PublishDate")]
        public DateTime publishDate { get; set; }

        public albumyDTO(int idAlbum, string albumName, DateTime PublishDate)
        {
            this.idAlbum = idAlbum;
            this.albumName = albumName;
            this.publishDate = publishDate;

        }
        public albumyDTO() { }
    }
}
