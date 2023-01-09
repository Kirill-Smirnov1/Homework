//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int a = 0;
int Numbers(int m, int n)
{
    if (m > n) return m;
    a = a + m;
    Console.Write($" {m} ");
    return Numbers(m+1, n);
    
    
}
Numbers(-4,10);
Console.Write($"Сумма элементов: {a} ");
