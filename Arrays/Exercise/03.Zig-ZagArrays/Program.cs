int n = int.Parse(Console.ReadLine());

string[] firstArray = new string[n];
string[] secondArray = new string[n];
bool isFirst = true;

for  (int i = 0; i < n; i++)
{
    string numbers = Console.ReadLine();
    string[] numbersArray = numbers.Split();

    if (isFirst)
    {
        firstArray[i] = numbersArray[0];
        secondArray[i] = numbersArray[1];
    }
    else
    {
        secondArray[i] = numbersArray[0];
        firstArray[i] = numbersArray[1];
    }

    isFirst = !isFirst;
}
Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));