//Task 2 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

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


//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Enter a number: ");
string StrNum = Console.ReadLine();
int num = int.Parse(StrNum);

if (num < 100 &&  num > 999)
{
    System.Console.WriteLine("num is encorrect");
    }
else
{
    int num1 = (num % 100) / 10;
    System.Console.WriteLine(num1);    
}

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Enter a number: ");
string StrNum = Console.ReadLine();
int num = int.Parse(StrNum);

if (num < 100)
{
    System.Console.WriteLine("Third num is out");
    }
else
{
    int num1 = (num / 10) % 10;
    System.Console.WriteLine(num1);    
}
