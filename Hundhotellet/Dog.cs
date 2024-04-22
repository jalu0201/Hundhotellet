using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Dog
    {
        public string name;
        public string chipNumber;
        public Owner owner;

        public Dog(string n, string c, Owner o)
        {
            name = n;
            chipNumber = c;
            owner = o;
        }
    }
}
