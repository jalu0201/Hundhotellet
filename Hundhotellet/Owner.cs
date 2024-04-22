using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Owner
    {
        public string firstName;
        public string lastName;
        public Adress adress;

        public Owner(string firstName, string lastName, Adress adress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.adress = adress;
        }
    }
}
