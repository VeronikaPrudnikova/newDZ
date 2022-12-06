// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int CutNumber(int num)
{
    int ed = num / 10;
    int sot = ed % 10;
   
    return sot;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 100 && num < 1000)
{
    int newNum = CutNumber(num);
    Console.WriteLine($"{num} -> {newNum}");
}
else
{
    Console.WriteLine("invalid number");
}
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
int CutNumber(int num)
{
   while(num >= 1000)
   {
        num = num /10;
   }
    int sot = num % 10;
    return sot;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 100)
{
    int newNum = CutNumber(num);
    Console.WriteLine($"{num} -> {newNum}");
}
else
{
    Console.WriteLine("третьей цифры нет!");
}
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
void IsWeekDay(int num)
{
    if(num < 1  || num > 7 )
    {
        Console.WriteLine("Некорректное значение!");
    }
    else 
    {
        if(num > 5)
        {
            Console.WriteLine($"{num} -> Да!");
        }
        else
        {
            Console.WriteLine($"{num} -> Нет!");
        } 
    }
}

Console.WriteLine("enter the day of the week from 1 to 7: ");
int num = Convert.ToInt32(Console.ReadLine());
IsWeekDay(num);
*/