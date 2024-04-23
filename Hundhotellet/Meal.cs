using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class Meal
    {
        public int hourOfDay;
        public string foodType;
        public string amount;

        public Meal(int h, string f,string a)
        {
            hourOfDay = h;
            foodType = f;
            amount = a;
        }
        public override string ToString()
        {
            return "kl " + hourOfDay + ": " + foodType + " " + amount;
        }
    }
  
}
