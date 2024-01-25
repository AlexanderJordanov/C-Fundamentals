class Programm
{
    static void Main()
    {
        List <int> sinoLeaves= Console.ReadLine()
            .Split(":")
            .Select(int.Parse)
            .ToList();
        int steps = int.Parse(Console.ReadLine());
        int timePerStep = int.Parse(Console.ReadLine());

        int hours = sinoLeaves[0];
        int minutes = sinoLeaves[1];
        int seconds = sinoLeaves[2];

        for (int i = 1; i <= steps; i++)
        {
            seconds += timePerStep;

            if (seconds > 59)
            {
                minutes++;
                seconds -= 60;
            }

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
        }

        if (seconds < 10)
        {
            if (minutes < 10)
            {
                if (hours < 10)
                {
                    Console.WriteLine($"Time Arrival: 0{hours}:0{minutes}:0{seconds}");
                }
                else
                {
                    Console.WriteLine($"Time Arrival: {hours}:0{minutes}:0{seconds}");
                }
            }
            else
            {
                Console.WriteLine($"Time Arrival: {hours}:{minutes}:0{seconds}");
            }
        }
        else if (minutes < 10)
        {
            if (hours < 10)
            {
                Console.WriteLine($"Time Arrival: 0{hours}:0{minutes}:{seconds}");
            }
            else
            {
                Console.WriteLine($"Time Arrival: {hours}:0{minutes}:{seconds}");
            }
        }
        else if (hours < 10)
        {
            Console.WriteLine($"Time Arrival: 0{hours}:{minutes}:{seconds}");
        }
        else
        {
            Console.WriteLine($"Time Arrival: {hours}:{minutes}:{seconds}");
        }

    }

}
