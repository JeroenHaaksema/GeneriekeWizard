using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneriekeWizard.Store.Gezinssamenstelling.Gezinssamenstelling.Actions
{
    public class VerwijderVolwassene
    {
        public VerwijderVolwassene()
        {

        }

        public VerwijderVolwassene(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
