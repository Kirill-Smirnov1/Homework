﻿//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Write("Введите пятизначное число а: ");
int a = int.Parse(Console.ReadLine());
if ((-100000 < a && a < -10000) || (a < 100000 && a > 10000))
{
    int b5 = Math.Abs(a % 10);
    int c4 = Math.Abs(a % 100 / 10);
    int d2 = Math.Abs(a % 10000 / 1000);
    int e1 = Math.Abs(a / 10000);
    if(b5 == e1 && d2 == c4)
    {
       Console.Write($"Число {a} палиндром!");
    }
    else
    Console.Write($"Число {a} не палиндром!");
}
else
Console.Write("Число не пятизначное!");
