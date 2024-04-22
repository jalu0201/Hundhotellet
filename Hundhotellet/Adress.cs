using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Adress
    {
        public string gatuAdress;
        public string stad;
        public string postnummer;

        public Adress (string gatuAdress, string stad, string postnummer)
        {
            this.gatuAdress = gatuAdress;
            this.stad = stad;
            this.postnummer = postnummer;
        }
    }
}
