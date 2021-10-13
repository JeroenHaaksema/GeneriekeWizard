using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Managers;

namespace WebAPI.Controllers
{
    [Route("api/pakketvergelijker")]
    [ApiController]
    public class PakketVergelijkerController : ControllerBase
    {
        private IAanvullendeVerzekeringManager _aanvullendeVerzekeringManager;
        private ITandVerzekeringManager _tandVerzekeringManager;

        public PakketVergelijkerController(IAanvullendeVerzekeringManager aanvullendeVerzekeringManager, ITandVerzekeringManager tandVerzekeringManager)
        {
            _aanvullendeVerzekeringManager = aanvullendeVerzekeringManager;
            _tandVerzekeringManager = tandVerzekeringManager;
        }


        //Methode om verzekeringen op te halen 
        // /api/pakketvergelijker/verzekering/
        [HttpGet("tandverzekeringen")]
        public ActionResult GetTandVerzekeringen()
        {
            return Ok(_tandVerzekeringManager.GetAanvullendeVerzekeringenVoorPakketvergelijker());
        }

        //Methode om verzekeringen op te halen 
        // /api/pakketvergelijker/verzekering/
        [HttpGet("aanvullendeverzekeringen")]
        public ActionResult GetAanvullendeVerzekeringen()
        {
            return Ok(_aanvullendeVerzekeringManager.GetAanvullendeVerzekeringenVoorPakketvergelijker());
        }

        //Methode met string als eindpunt
        // /api/pakketvergelijker/vergoedingen/{endpoint}
        [HttpGet("tandvergoedingen")]
        public ActionResult GetTandVergoedingen()
        {
            return Ok(_tandVerzekeringManager.GetVergoedingen());

        }

        //Methode met string als eindpunt
        // /api/pakketvergelijker/vergoedingen/{endpoint}
        [HttpGet("aanvullendevergoedingen")]
        public ActionResult GetAanvullendeVergoedingen()
        {
            return Ok(_aanvullendeVerzekeringManager.GetVergoedingen());
        }

    }
}
