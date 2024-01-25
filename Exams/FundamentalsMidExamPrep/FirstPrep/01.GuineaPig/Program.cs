class Programm
{
    static void Main()
    {
        double foodInKilograms = double.Parse(Console.ReadLine());
        double hayInKilograms = double.Parse(Console.ReadLine());
        double coverInKilograms = double.Parse(Console.ReadLine());
        double pigInKilograms = double.Parse(Console.ReadLine());



        double foodInGrams = foodInKilograms * 1000;
        double hayInGrams = hayInKilograms * 1000;
        double coverInGrams = coverInKilograms * 1000;
        double pigInGrams = pigInKilograms * 1000;


        for (int i = 1; i <= 30; i++)
        {
            foodInGrams -= 300;

            if (i % 2 == 0)
            {
                hayInGrams -= foodInGrams * 0.05;
            }

            if (i % 3 == 0)
            {
                coverInGrams -= pigInGrams / 3;
            }

            if (foodInGrams <= 0 || hayInGrams <= 0 || coverInGrams <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
                return;
            }
        }

        Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInGrams/1000:f2}, Hay: {hayInGrams/1000:f2}, Cover: {coverInGrams/1000:f2}.");
    }

}