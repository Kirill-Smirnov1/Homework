//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
void Print(int[,] arr)
{
    int stroka_size = arr.GetLength(0);
    int stolbi_size = arr.GetLength(1);
    for (int i = 0; i < stroka_size; i++)
    {
        for (int j = 0; j < stolbi_size; j++)
            Console.Write($"{arr[i, j],3}");
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
int[,] MatrixSumm(int[,] arr_first, int[,] arr_second)
{
    int stroka_size = arr_first.GetLength(0);
    int stolbi_size = arr_first.GetLength(1); 
    int[,] pr_matrix = new int[stroka_size, stolbi_size];
    if(stroka_size != arr_second.GetLength(0) || stolbi_size != arr_second.GetLength(1)) return pr_matrix;
    for (int i = 0; i < stroka_size; i++)
        for (int j = 0; j < stolbi_size; j++)
            pr_matrix[i,j] = arr_first[i,j] * arr_second[i,j];
    return pr_matrix;
}
Console.Write("Введите количество строк: ");
int stroka = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolb = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(stroka, stolb, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Print(arr_1);

Console.Write("Введите количество строк: ");
int stroka_1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolb_1 = int.Parse(Console.ReadLine());
int[,] arr_2 = MassNums(stroka, stolb, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Print(arr_2);
MatrixSumm(arr_1, arr_2);

int[,] arr_3 = MatrixSumm(arr_1, arr_2);
Print(arr_3);






