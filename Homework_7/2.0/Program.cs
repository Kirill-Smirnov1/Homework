//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
void Print(int[,] arr)
{
    int stroka_size = arr.GetLength(0);
    int stolbi_size = arr.GetLength(1);
    for (int i = 0; i < stroka_size; i++)
    {
        for (int j = 0; j < stolbi_size; j++)
            Console.Write($"{arr[i, j],6}");
        Console.WriteLine();

    }
    Console.WriteLine();
}
int[,] MassNums(int stroka, int stolb, int from, int to)
{
    int [,] arr = new int[stroka, stolb];
    for (int i = 0; i < stroka; i++)
        for (int j = 0; j < stolb; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}
string FindElement(int[,] arr, int f, int s)
{
    int stroka = arr.GetLength(0);
    int stolb = arr.GetLength(1);
    if(f > stroka || f <=0 || s > stolb || s <=0)
        return $"{f},{s}  нет в массиве";
    return $"arr[{f},{s}] = {arr[f-1,s-1]} в массиве";

}
Console.Write("Введите количество строк: ");
int stroka = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolb = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(stroka, stolb, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Print(arr_1);

Console.Write("Введите позицию строки: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int second = int.Parse(Console.ReadLine());
Console.WriteLine(FindElement( arr_1, first, second));