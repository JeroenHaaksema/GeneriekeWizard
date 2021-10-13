using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.HelpMijKiezen;

namespace WebAPI.Services
{
    public class HelpMijKiezenRepository : IHelpMijKiezenRepository
    {
        private List<HelpMijKiezenDTO> HelpMijKiezenVragenEnantwoorden;

        public HelpMijKiezenRepository()
        {
            HelpMijKiezenVragenEnantwoorden = new List<HelpMijKiezenDTO>()
            {
                new HelpMijKiezenDTO { naam="Alternatieve behandelingen", vraag="Hoeveel alternatieve behandelingen wilt u vergoed krijgen?", eenheid="Per jaar",
                    antwoorden = new int []{ 1, 3, 5, 7 }, pakketBijAntwoord = new List<KeyValuePair<int,string>>(){
                        new KeyValuePair<int, string>(1, "Eigen keuze"),
                        new KeyValuePair<int, string>(3, "Eigen keuze"),
                        new KeyValuePair<int, string>(5, "Ruime keuze"),
                        new KeyValuePair<int, string>(7, "Vrije keuze"),
                    }
                    },
                new HelpMijKiezenDTO { naam="Bril vanaf 18 jaar", vraag="Hoeveel wilt u van uw bril vergoed krijgen", eenheid="Per drie jaar",
                    antwoorden = new int []{ 100, 300, 500, 700 }, pakketBijAntwoord = new List<KeyValuePair<int,string>>(){
                        new KeyValuePair<int, string>(100, "Eigen keuze"),
                        new KeyValuePair<int, string>(300, "Eigen keuze"),
                        new KeyValuePair<int, string>(500, "Ruime keuze"),
                        new KeyValuePair<int, string>(700, "Vrije keuze"),
                    }
                    },
                new HelpMijKiezenDTO { naam="Fysiotherapie vanaf 18 jaar", vraag="Hoeveel fysiotherapie behandelingen wilt u vergoed krijgen", eenheid="Per drie jaar",
                    antwoorden = new int []{ 3, 5,7,9 }, pakketBijAntwoord = new List<KeyValuePair<int,string>>(){
                        new KeyValuePair<int, string>(3, "Eigen keuze"),
                        new KeyValuePair<int, string>(5, "Ruime keuze"),
                        new KeyValuePair<int, string>(7, "Ruime keuze"),
                        new KeyValuePair<int, string>(9, "Vrije keuze"),
                    }
                    },
                new HelpMijKiezenDTO { naam="Orthodontotie tot 18 jaar", vraag="Welke vergoeding voor orthodontie wilt u?", eenheid="Per jaar",
                    antwoorden = new int []{ 300,500,700 }, pakketBijAntwoord = new List<KeyValuePair<int,string>>(){
                        new KeyValuePair<int, string>(300, "Tandvullend"),
                        new KeyValuePair<int, string>(500, "Tandvullender"),
                        new KeyValuePair<int, string>(700, "Tandvullendst"),
                    }
                    },
                new HelpMijKiezenDTO { naam="Mondzorg vanaf 18 jaar", vraag="Welke vergoeding voor mondzorg wilt u?", eenheid="Per jaar",
                antwoorden = new int []{ 200,400,500,800 }, pakketBijAntwoord = new List<KeyValuePair<int,string>>(){
                    new KeyValuePair<int, string>(200, "Tandvullend"),
                    new KeyValuePair<int, string>(400, "Tandvullender"),
                    new KeyValuePair<int, string>(500, "Tandvullendst"),
                    new KeyValuePair<int, string>(800, "Tandvullendst"),
                }
                },
            };
        }
        public List<HelpMijKiezenDTO> GetHelpMijKiezenVragenEnAntwoorden()
        {
            return HelpMijKiezenVragenEnantwoorden;
        }
    }

}
