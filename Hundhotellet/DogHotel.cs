using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundhotellet
{
    internal class DogHotel
    {
        public Dog[] dogArray = new Dog[10];
        double costPerNight = 300;
        public void SetDog(int cageNumber, Dog dog)
        {
            dogArray[cageNumber] = dog;
        }
        public Dog GetDog(int cageNumber)
        {
            return dogArray[cageNumber];
        }
        public void PrintInfo()
        {
            for (int i = 0; i < dogArray.Length; i++)
            {
                Dog dog = dogArray[i];
                if (dog != null)
                {
                    Console.WriteLine("Bur " + i + ": " + dog.name + " " + "Ägare: " +
                        dog.owner.firstName + " " + dog.owner.lastName + " " + dog.owner.adress.gatuAdress + " "
                        + dog.owner.adress.stad + " " + dog.owner.adress.postnummer);
                }
            }
        }

        public void PrintFeedingSchedule()
        {
            for (int i = 0; i < dogArray.Length; i++)
            {
                Dog dog = dogArray[i];

                if (dog != null)
                {
                    Console.WriteLine("Bur " + i + ": " + dog.name);
                    foreach (Meal meal in dog.mealList)
                    {
                        Console.WriteLine(meal.ToString());
                    }
                }
            }


        }
         public void PrintPickups()
        {
            for (int i = 0; i < dogArray.Length; i++)
            {
                if (dogArray[i] != null)
                {
                    Console.WriteLine("Bur " + i + ": " + dogArray[i].name);

                    if (dogArray[i].visit.dropoffTime.Hour < DateTime.Now.Hour)
                    {
                        Console.WriteLine("Kom hit: kl " + dogArray[i].visit.dropoffTime.Hour);
                    }
                    if (dogArray[i].visit.pickupTime.Hour > DateTime.Now.Hour)
                    {
                        Console.WriteLine("Blir hämtad: kl " + dogArray[i].visit.pickupTime.Hour);
                    }
                }
            }

        }

        public void PrintInvoice()
        {
            for (int i = 0; i < dogArray.Length; i++)
            {
                Dog dog = dogArray[i];

                if (dog != null)
                {
                    Console.WriteLine("Bur " + i + ": " + dog.name + " Ägare: "
                    + dog.owner.firstName + " " + dog.owner.lastName
                    + " Adress: " + dog.owner.adress.gatuAdress + " " + dog.owner.adress.stad
                    + " " + dog.owner.adress.postnummer + " Kom hit: kl " + dogArray[i].visit.dropoffTime.Hour +
                    " Blir hämtad: kl " + dogArray[i].visit.pickupTime.Hour + " Faktura: " + costPerNight);
                }
                if (dog == null)
                {
                    Console.WriteLine("Felmeddelande: Finns ingen hund i buren");
                }
            }
        }
        



    }
}
