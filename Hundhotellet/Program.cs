using System.Runtime.CompilerServices;

namespace Hundhotellet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogHotel dogHotel = new DogHotel();
            AddTestData(dogHotel);
            Console.WriteLine("\n\rDogInfo");
            dogHotel.PrintInfo();
            Console.WriteLine("\n\rFeedingSchedule");
            dogHotel.PrintFeedingSchedule();
            Console.WriteLine("\n\rVisitTime");
            dogHotel.PrintPickups();
        }
        static void AddTestData(DogHotel dogHotel)
        {
            Adress testAdress1 = new Adress("Hundgatan 1", "Sala", "73300");
            Owner testOwner1 = new Owner("Arvid","Eriksson", testAdress1);
            Adress testAdress2 = new Adress("Hundgatan 2", "Sala", "73300");
            Owner testOwner2 = new Owner("Barvid", "Eriksson", testAdress2);
            Visit testVisit1 = new Visit(new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,6,0,0),new DateTime(DateTime.Now.Year, DateTime.Now.Month,DateTime.Now.Day,17,0,0));
            Visit testVisit2 = new Visit(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 0, 0));


            Dog testDog1 = new Dog("Fido", "123456",testOwner1,testVisit1);
            Dog testDog2 = new Dog("Lassie", "654321",testOwner2, testVisit2);
            dogHotel.SetDog(2, testDog1);
            dogHotel.SetDog(5, testDog2);

            Meal testMeal1 = new Meal(7, "kött", "2kg");
            Meal testMeal2 = new Meal(14, "pasta", "500g");
            Meal testMeal3 = new Meal(8, "fisk", "2st");
            Meal testMeal4 = new Meal(13, "smoothie", "350ml");

            testDog1.AddMeal(testMeal1);
            testDog1.AddMeal(testMeal2);
            testDog2.AddMeal(testMeal3);
            testDog2.AddMeal(testMeal4);

          

        }


    }
}