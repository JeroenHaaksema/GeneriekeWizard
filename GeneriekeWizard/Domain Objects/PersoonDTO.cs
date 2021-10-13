using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GeneriekeWizard.Domain_Objects.GeslachtEnum;

namespace GeneriekeWizard.Domain_Objects
{
    public class PersoonDTO
    {

        public PersoonDTO(int id, VerzekerdeType verzekerdeType, string voorletters, string achternaam, Geslacht geslacht, Nationaliteit nationaliteit, string bsn, string tussenvoegsel)
        {
            this.id = id;
            this.verzekerdeType = verzekerdeType;
            this.voorletters = voorletters;
            this.achternaam = achternaam;
            this.geslacht = geslacht;
            this.nationaliteit = nationaliteit;
            this.bsn = bsn;
            this.tussenvoegsel = tussenvoegsel;
        }

        public int id { get; set; }
        public VerzekerdeType verzekerdeType { get; set; }
        public string voorletters { get; set; }
        public string? tussenvoegsel { get; set; }
        public string achternaam { get; set; }
        public Geslacht geslacht { get; set; }
        public Nationaliteit nationaliteit { get; set; }
        public string bsn { get; set; }
        public Basisverzekering basisverzekering { get; set; }
        public Aanvullendeverzekering aanvullendeverzekering { get; set; }
        public Tandverzekering tandverzekering { get; set; }
        public int eigenRisico { get; set; } = 0;

    }
}
