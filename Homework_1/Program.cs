// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if(a > b)
{
    Console.WriteLine($"Большее число: {a}, а меньшее {b}");
}
  else if (a == b)  
{
    Console.WriteLine($"Числа равны ");
}    
else
{
    Console.WriteLine($"Большее число: {b} а меньшее {a}");
}

  

