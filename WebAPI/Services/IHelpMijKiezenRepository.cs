using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.HelpMijKiezen;

namespace WebAPI.Services
{
    public interface IHelpMijKiezenRepository
    {
        public List<HelpMijKiezenDTO> GetHelpMijKiezenVragenEnAntwoorden();
    }
}
