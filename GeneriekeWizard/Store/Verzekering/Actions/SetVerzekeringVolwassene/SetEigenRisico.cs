using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Verzekering.Actions.SetVerzekeringVolwassene
{
    public class SetEigenRisico
    {
        public int persoonId { get; }
        public int eigenRisico { get; }
        public SetEigenRisico(int persoonId, int eigenRisico)
        {
            this.persoonId = persoonId;
            this.eigenRisico = eigenRisico;
        }
    }
}
