using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Managers;

namespace WebAPI.Controllers
{
    [Route("api/verzekering")]
    [ApiController]
    public class VerzekeringenController : ControllerBase
    {
        private IVerzekeringenManager _verzekeringenManager;

        public VerzekeringenController(IVerzekeringenManager verzekeringenManager)
        {
            _verzekeringenManager = verzekeringenManager;
        }

        [HttpGet("basis")]
        public ActionResult GetBasisverzekeringen()
        {
            return Ok(_verzekeringenManager.GetBasisverzekeringen());
        }

        [HttpGet("tand")]
        public ActionResult GetTandverzekeringen()
        {
            return Ok(_verzekeringenManager.GetTandverzekeringen());
        }

        [HttpGet("aanvullend")]
        public ActionResult GetAanvullendeverzekering()
        {
            return Ok(_verzekeringenManager.GetAanvullendeverzekeringen());
        }

    }
}
