int key = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
string word = "";
for (int i = 0; i < n; i++)
{
    char letter = char.Parse(Console.ReadLine());

    char letterWithKey = (char)(key + letter);

    string oneLetter = letterWithKey.ToString();

    word += oneLetter;
}
Console.WriteLine(word);