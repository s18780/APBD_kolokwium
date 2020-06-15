using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace kolokwium_2.DTOs
{
    public class Music
    {
        public int idMusicLabel { get; set; }
        public string Name { get; set; }
        [JsonProperty("album")]
        public List<albumyDTO> album { get; set; }

        public Music(int idMusicLabel,String Name,List<albumyDTO> album)
        {
            this.idMusicLabel = idMusicLabel;
            this.Name = Name;
            this.album = album;
        }

        public Music() { }
    }
}
