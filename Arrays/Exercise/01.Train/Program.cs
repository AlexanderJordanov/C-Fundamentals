int n = int.Parse(Console.ReadLine());

int[] trainArray = new int[n];

int totalPassangers = 0;

for (int i = 0; i < n; i++)
{
    int passengersInWagon = int.Parse((Console.ReadLine()));
    trainArray[i] = passengersInWagon;
    totalPassangers += passengersInWagon;

    
}
Console.WriteLine(string.Join(" ",trainArray));
Console.WriteLine( totalPassangers );
