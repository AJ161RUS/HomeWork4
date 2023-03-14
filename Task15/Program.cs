/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

if (a <1 || a > 7 )
    Console.Write($"Неверный ввод дня недели ");
if (a == 1)
    Console.Write($"Понедельник ");
else if (a == 2)
    Console.Write($"Вторник ");
else if (a == 3)
    Console.Write($"Среда ");
else if (a == 4)
    Console.Write($"Четверг ");
else if (a == 5)
    Console.Write($"Пятница ");
    else if (a == 6)
    Console.Write($"Суббота ");
    else if (a == 7)
    Console.Write($"Воскресенье ");


if (a == 6 || a ==7) 
 
{
    Console.WriteLine($"- Выходной день недели ");
}
else 
Console.WriteLine($"- Рабочий день недели ");




