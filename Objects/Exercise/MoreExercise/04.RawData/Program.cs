class Programm
{
    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }

    class Cargo 
    {   
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }

    class Car 
    {
        public Car(string[] carInfo)
        {
            Model = carInfo[0];
            Engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
            Cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }



    static void Main()
    {
        List<Car> cars = new List<Car>();
        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            cars.Add(new Car(Console.ReadLine().Split()));
        }

        string type = Console.ReadLine();

        if (type == "fragile")
        {
            foreach(Car car in cars.Where(c => c.Cargo.CargoType == type && c.Cargo.CargoWeight < 1000))
            {
                Console.WriteLine(car.Model);
            }
        }
        else if (type == "flamable")
        {
            foreach (Car car in cars.Where(c => c.Cargo.CargoType == type && c.Engine.EnginePower > 250))
            {
                Console.WriteLine(car.Model);
            }
        }
/*
2
ChevroletAstro 200 180 1000 fragile
Citroen2CV 190 165 900 fragile
fragile


4
ChevroletExpress 215 255 1200 flamable
ChevroletAstro 210 230 1000 flamable
DaciaDokker 230 275 1400 flamable
Citroen2CV 190 165 1200 fragile
flamable
*/
    }
}
