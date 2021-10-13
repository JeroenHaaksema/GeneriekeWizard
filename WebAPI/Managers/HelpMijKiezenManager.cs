using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities.HelpMijKiezen;
using WebAPI.Services;

namespace WebAPI.Managers
{
    public class HelpMijKiezenManager : IHelpMijKiezenManager
    {
        private readonly IHelpMijKiezenRepository _helpMijKiezenRepository;

        public HelpMijKiezenManager(IHelpMijKiezenRepository helpMijKiezenRepository)
        {
            _helpMijKiezenRepository = helpMijKiezenRepository;
        }
        public List<HelpMijKiezenDTO> GetHelpMijKiezenVragenEnAntwoorden()
        {
            return _helpMijKiezenRepository.GetHelpMijKiezenVragenEnAntwoorden();
        }

    }
}
