using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_dinozaurow
{
    public class ExtinctAnimal
    {
        public string Nazwa {  get; set; }
        public string Epoka { get; set; }
        public string Miejsce_wystepowania { get; set; } 

        public override string ToString()
        {
            return Nazwa+ " - " + Epoka + " - " + Miejsce_wystepowania; 
        }
    }
}
