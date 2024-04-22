namespace Hundhotellet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogHotel dogHotel = new DogHotel();
            AddTestData(dogHotel);
            dogHotel.PrintInfo();
        }
        static void AddTestData(DogHotel dogHotel)
        {
            Adress testAdress1 = new Adress("Hundgatan 1", "Sala", "73300");
            Owner testOwner1 = new Owner("Arvid","Eriksson", testAdress1);
            Adress testAdress2 = new Adress("Hundgatan 2", "Sala", "73300");
            Owner testOwner2 = new Owner("Barvid", "Eriksson", testAdress2);
           


            Dog testDog1 = new Dog("Fido", "123456",testOwner1);
            Dog testDog2 = new Dog("Lassie", "654321",testOwner2);
            dogHotel.SetDog(2, testDog1);
            dogHotel.SetDog(5, testDog2);

        }


    }
}