int nKegs = int.Parse(Console.ReadLine());
string kegModel = "";
decimal kegVolumeMax = 0;
for (int i = 0; i < nKegs; i++)
{
    string kegModelName = Console.ReadLine();
    decimal kegRadius = decimal.Parse(Console.ReadLine());
    decimal kegHeight = decimal.Parse(Console.ReadLine());

    decimal kegVolume = (decimal)Math.PI * (kegRadius * kegRadius) * kegHeight;

    if (kegVolume > kegVolumeMax)
    {
        kegVolumeMax = kegVolume;
        kegModel = kegModelName;
    }
}
/*
2
Smaller Keg
2.41
10
Bigger Keg
5.12
20
*/


Console.WriteLine(kegModel);