/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
                        */
int A = new Random().Next(100, 1000);
Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine()!, out A);

int B = A / 1000 + A % 100 ;
int C = B / 10;
Console.Write($" {C}");
