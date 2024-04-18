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
            Dog testDog1 = new Dog("fido", "123456");
            Dog testDog2 = new Dog("lassie", "654321");
            dogHotel.SetDog(2, testDog1);
            dogHotel.SetDog(5, testDog2);
        }


    }
}