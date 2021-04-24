using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5
{
    class Vklad
    {
        public double Procent { get; set; }
        public double Money { get; set; }
        public Client client { get; set; }
    }
    class Client 
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Passport { get; set; }

    }
}
