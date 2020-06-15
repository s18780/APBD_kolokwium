using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kolokwium_2.DTOs;
using kolokwium_2.Services;
using Microsoft.AspNetCore.Mvc;



namespace kolokwium_2.Controllers
{
    [Route("api/music")]
    [ApiController]
    public class MusicController : ControllerBase
    {

        private readonly IDbServiceEf _service;

        public MusicController(IDbServiceEf service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("music-labels/{id}")]
        public IActionResult Getmusic(String Name)
        {

            return Ok(_service.Getmusic(Name));
        }
    }
}
