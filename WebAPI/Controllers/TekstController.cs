using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Managers;

namespace WebAPI.Controllers
{
    [Route("api/teksten")]
    [ApiController]
    public class TekstController : ControllerBase
    {
        private ITekstManager _tekstManager;

        public TekstController(ITekstManager tekstManager)
        {
            _tekstManager = tekstManager;
        }
        [HttpGet("keuzehulp")]
        public ActionResult GetTekstenKeuzehulp()
        {
            return Ok(_tekstManager.GetKeuzehulpTekstBlokken());
        }

        [HttpGet("verzekeringen")]
        public ActionResult GetVerzekeringTeksten()
        {
            return Ok(_tekstManager.GetVerzekeringTeksten());
        }
    }
}
