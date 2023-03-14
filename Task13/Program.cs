/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
645 -> 5

78 -> третьей цифры нет

32679 -> 6          */

int A;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out A);

/*if (A > 99)
{
    while (A > 999)
    {
        A = A / 10;
    }
    Console.WriteLine (A % 10);
}
else
{
    Console.WriteLine($"{A} -> третьей цифры нет");
}*/


