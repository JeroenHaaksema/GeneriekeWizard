using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GeneriekeWizard.Domain_Objects.GeslachtEnum;

namespace GeneriekeWizard.Domain_Objects
{
    public class Persoon
    {
        public Persoon(int id, VerzekerdeType verzekerdeType)
        {
            this.id = id;
            this.verzekerdeType = verzekerdeType;
        }

        public Persoon()
        {

        }

        public int id { get; }
        public VerzekerdeType verzekerdeType { get; set; }
        public string voorletters { get; set; }
        public string? tussenvoegsel { get; set; }
        public string achternaam { get; set; }
        public Geslacht geslacht { get; set; }
        public Nationaliteit nationaliteit { get; set; }
        public string bsn { get; set; }

        public Boolean IsKind()
        {
            return this.verzekerdeType.Equals(VerzekerdeType.Kind);
        }

        public Boolean IsVerzekeringnemer()
        {
            return this.verzekerdeType.Equals(VerzekerdeType.Hoofdverzekerde);
        }

        public string GetPersoonsType()
        {
            if (verzekerdeType.Equals(VerzekerdeType.Hoofdverzekerde))
            {
                return "Hoofdverzekerde";
            }
            else if (verzekerdeType.Equals(VerzekerdeType.Medeverzekerde))
            {
                return "Medeverzekerde";
            }
            else
            {
                return "Kind";
            }
        }

        public string GetNaam()
        {
            return voorletters + " " + (tussenvoegsel != null ? tussenvoegsel : "") + " " + achternaam;
        }
    }
}
