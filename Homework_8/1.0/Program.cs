//Урок 8. Двумерные массивы. Продолжение
//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
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
void Sort(int[,] arr)
{
    int stroka_size = arr.GetLength(0);
    int stolbi_size = arr.GetLength(1);
    for (int i = 0; i < stroka_size; i++)
    {
        for (int j = 0; j < stolbi_size; j++)
        {
            for (int k = 0; k < stolbi_size - j -1; k++)
            if(arr[i,k] < arr[i, k + 1])
                (arr[i,k], arr[i, k + 1]) = (arr[i, k + 1], arr[i,k]);

        }
    }
}
Console.Write("Введите количество строк: ");
int stroka = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolb = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(stroka, stolb, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Print(arr_1);
Sort(arr_1);
Print(arr_1);
