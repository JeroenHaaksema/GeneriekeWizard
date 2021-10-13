using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Entities.HelpMijKiezen
{
    public class HelpMijKiezenDTO
    {
        public HelpMijKiezenDTO() { }

        public string naam { get; set; }
        public string vraag { get; set; }
        public int[] antwoorden { get; set; }
        public string eenheid { get; set; }
        public List<KeyValuePair<int, string>> pakketBijAntwoord { get; set; }
    }
}
