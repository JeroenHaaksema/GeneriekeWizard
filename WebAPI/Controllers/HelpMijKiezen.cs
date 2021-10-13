using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Managers;

namespace WebAPI.Controllers
{
    [Route("api/helpmijkiezen")]
    [ApiController]
    public class HelpMijKiezen : ControllerBase
    {
        private IHelpMijKiezenManager _helpMijKiezenManager;

        public HelpMijKiezen(IHelpMijKiezenManager helpMijKiezenManager)
        {
            _helpMijKiezenManager = helpMijKiezenManager;
        }

        [HttpGet()]
        public ActionResult getHelpMijKiezenVragenEnAntwoorden()
        {
            return Ok(_helpMijKiezenManager.GetHelpMijKiezenVragenEnAntwoorden());
        }
    }
}