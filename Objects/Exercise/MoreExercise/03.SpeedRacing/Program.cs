/*
2
AudiA4 23 0.3
BMW-M2 45 0.42
Drive BMW-M2 56
Drive AudiA4 5
Drive AudiA4 13
End
   
3
AudiA4 18 0.34
BMW-M2 33 0.41
Ferrari-488Spider 50 0.47
Drive Ferrari-488Spider 97
Drive Ferrari-488Spider 35
Drive AudiA4 85
Drive AudiA4 50
End  
*/
class Programm
{
    class Car 
    {
        public Car(string model, decimal fuelAmount, decimal fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
        }
        public string Model { get; set; }
        public decimal FuelAmount { get; set; }
        public decimal FuelConsumption { get; set;}
        public decimal TravelDistance { get; set;}

        public void DriveCar(decimal distance)
        {
            if (distance * FuelConsumption <= FuelAmount)
            {
                TravelDistance += distance;
                FuelAmount -= distance * FuelConsumption;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }

    static void Main()
    {
        List<Car> cars = new List<Car>();
        int numberOfCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCars; i++)
        {
            string[] carArguments = Console.ReadLine().Split();

            string model = carArguments[0];
            decimal fuelAmount = decimal.Parse(carArguments[1]);
            decimal fuelConsumption = decimal.Parse(carArguments[2]);

            Car car = new Car(model, fuelAmount, fuelConsumption);
            cars.Add(car);
        }

        string input = "";
        while ((input = Console.ReadLine())!= "End")
        {
            string[] driveInput = input.Split();

            cars.Find(x => x.Model == driveInput[1]).DriveCar(decimal.Parse(driveInput[2]));
        }

        foreach (Car car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelDistance}");
        }
    }
}