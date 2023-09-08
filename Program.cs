Console.Write("Enter a week day: ");
string StrNum = Console.ReadLine();
int day = int.Parse(StrNum);

if(day > 7)
{
    Console.WriteLine("Not a week day");
}

else if(day == 6 | day ==7)
{
    Console.WriteLine("Vacation");
}
else
{
    System.Console.WriteLine("Working");
}