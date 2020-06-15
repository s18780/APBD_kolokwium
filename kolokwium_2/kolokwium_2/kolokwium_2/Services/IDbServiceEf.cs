using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kolokwium_2.DTOs;
using kolokwium_2.Models;

namespace kolokwium_2.Services
{
    interface IDbServiceEf
    {
        public Album GetAlbum(string Index);
        public List<Album> GetAlbum();
        object Getmusic(string name);
        object GetMusician(string nickName);
    }
}
