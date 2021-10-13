using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.HelpMijKiezen;

namespace WebAPI.Managers
{
    public interface IHelpMijKiezenManager
    {
        public List<HelpMijKiezenDTO> GetHelpMijKiezenVragenEnAntwoorden();

    }
}
