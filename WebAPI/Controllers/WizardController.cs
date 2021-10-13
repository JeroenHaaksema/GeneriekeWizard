using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/wizard")]
    [ApiController]
    public class WizardController : ControllerBase
    {
        [HttpPost]
        public ActionResult PostVerzekering()
        {
            return Ok();
        }
    }
}
