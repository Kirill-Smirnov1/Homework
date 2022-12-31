//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
void Print(double[,] arr)
{
    int stroka_size = arr.GetLength(0);
    int stolbi_size = arr.GetLength(1);
    for (int i = 0; i < stroka_size; i++)
    {
        for (int j = 0; j < stolbi_size; j++)
            Console.Write($"{arr[i,j], 6}");
        Console.WriteLine();

    }
    Console.WriteLine();
}
double[,] MassNums(int stroka, int stolb, int from, int to)
{
    double[,] arr = new double[stroka, stolb];
    Random n_new = new Random();
    for (int i = 0; i < stroka; i++)
        for (int j = 0; j < stolb; j++)
            arr[i,j] = Math.Round(n_new.NextDouble() * (to - from ) + from, 2);
    return arr;        
}
Console.Write("Введите количество строк: ");
int stroka = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolb = int.Parse(Console.ReadLine());
double[,] arr_1 = MassNums(stroka, stolb, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Print(arr_1);
