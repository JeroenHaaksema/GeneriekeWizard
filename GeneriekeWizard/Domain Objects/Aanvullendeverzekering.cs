﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Domain_Objects
{
    public class Aanvullendeverzekering : Verzekering
    {
        public Aanvullendeverzekering()
        {
        }

        public Aanvullendeverzekering(int id, string naam, int prijs) : base(id, naam, prijs)
        {
        }
    }
}
