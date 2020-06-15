using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kolokwium_2.DTOs;
using kolokwium_2.Models;
using kolokwium_2.Services;

namespace kolokwium_2.Controllers
{
    [Route("api/music")]
    [ApiController]
    public class MusicianController : ControllerBase
    {
        private readonly IDbServiceEf _service;
        public MusicianController(IDbServiceEf service)
        {
            _service = service;
        }
        [HttpDelete]
        [Route("Musician")]
        public IActionResult GetMusician(string NickName)
        {
            return Ok(_service.GetMusician(NickName));
        }

    }
}
