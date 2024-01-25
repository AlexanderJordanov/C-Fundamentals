using System.Text;

class Programm
{
    static void Main()
    {
        string password = Console.ReadLine();

        
        string input = default;
        while ((input = Console.ReadLine()) != "Done")
        {
            string[] commandArguments = input.Split();


            if (commandArguments[0] == "TakeOdd")
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i < password.Length; i += 2)
                {
                    sb.Append(password[i]);
                }

                password = sb.ToString();
                Console.WriteLine(password);
            }

            else if (commandArguments[0] == "Cut")
            {
                string firstPart = password.Substring(0, int.Parse(commandArguments[1]));
                string secondPart = password.Substring(int.Parse(commandArguments[1]) + int.Parse(commandArguments[2]));

                password = firstPart + secondPart;


                Console.WriteLine(password);
            }

            else if (commandArguments[0] == "Substitute")
            {
                if (!password.Contains(commandArguments[1]))
                {
                    Console.WriteLine("Nothing to replace!");
                    continue;
                }
                password = password.Replace(commandArguments[1], commandArguments[2]);
                Console.WriteLine(password);
            }
        }

        Console.WriteLine($"Your password is: {password}");

    }

}