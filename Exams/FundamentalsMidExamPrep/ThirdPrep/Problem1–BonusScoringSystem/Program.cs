int students = int.Parse(Console.ReadLine());
int lectures = int.Parse(Console.ReadLine());
int additionalBonus = int.Parse(Console.ReadLine());

int maxBonus = int.MinValue;
int maxAttendencies = int.MinValue;

for (int currentStudent = 0; currentStudent < students; currentStudent++)
{
    int currentStudentAttendencies = int.Parse(Console.ReadLine());

    double totalBonus = Math.Round(1.0 * currentStudentAttendencies / lectures * (5 + additionalBonus));

    if (totalBonus > maxBonus)
    {
        maxBonus = (int)totalBonus;
        maxAttendencies = currentStudentAttendencies;
    }
}

Console.WriteLine($"Max Bonus: {maxBonus}.");
Console.WriteLine($"The student has attended {maxAttendencies} lectures.");
