using System.Drawing;

int startingYield = int.Parse(Console.ReadLine());
int days = 0, mined = 0;
while  (startingYield >= 100)
{
    days++;
    mined += startingYield;
    mined -= 26;
    startingYield -= 10;
}
mined -= 26;

if (mined < 0)
{
    mined = 0;
} 
Console.WriteLine(days);
Console.WriteLine(mined);