string variables = Console.ReadLine();

double[] variablesArray = variables.Split(' ').Select(double.Parse).ToArray();

for (int i = 0; i < variablesArray.Length; i++)
{
    int roundedVariable = (int)Math.Round(variablesArray[i], MidpointRounding.AwayFromZero);

    Console.WriteLine($"{variablesArray[i]} => {roundedVariable}");
}