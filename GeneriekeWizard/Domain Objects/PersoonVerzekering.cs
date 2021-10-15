using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Domain_Objects
{
    public class PersoonVerzekering
    {
        public PersoonVerzekering()
        {

        }

        public PersoonVerzekering(int persoonId, Basisverzekering basisverzekering, Aanvullendeverzekering aanvullendeverzekering, Tandverzekering tandverzekering, int eigenrisico)
        {
            this.persoonId = persoonId;
            this.basisverzekering = basisverzekering;
            this.aanvullendeverzekering = aanvullendeverzekering;
            this.tandverzekering = tandverzekering;
            this.eigenRisico = eigenRisico;
        }

        public int persoonId { get; set; }
        public Basisverzekering basisverzekering { get; set; }
        public Aanvullendeverzekering aanvullendeverzekering { get; set; }
        public Tandverzekering tandverzekering { get; set; }
        public int eigenRisico { get; set; } = 0;
    }
}
