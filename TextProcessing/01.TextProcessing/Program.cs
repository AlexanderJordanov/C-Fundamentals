class Programm
{
    static void Main()
    {
        string input = default;
        while ((input = Console.ReadLine()) != "end")
        {
            var reversedInput = input.Reverse().ToArray();

            Console.WriteLine($"{input} = {string.Join("", reversedInput)}");
        }

        
    }

}
