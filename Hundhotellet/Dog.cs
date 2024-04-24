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
        public List<Meal> mealList = new List<Meal>();
        public Visit visit;



        public Dog(string n, string c, Owner o, Visit v)
        {
            name = n;
            chipNumber = c;
            owner = o;
            visit = v;
            
        }

        public void AddMeal(Meal meal)
        {
            mealList.Add(meal);
        }

    }

}
