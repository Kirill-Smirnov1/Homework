//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void Srednee(int[,] arr)
{
   int stroka = arr.GetLength(0);
   int stolb = arr.GetLength(1);
   double res;
   for (int i = 0; i < stolb; i++)
   {
    res = 0;
    for (int j = 0; j < stroka; j++) res += arr[j,i];
    Console.Write($"{Math.Round(res / stroka, 2)};");
   }
}
Console.Write("Введите количество строк: ");
int stroka = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolb = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(stroka, stolb, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Print(arr_1);
Srednee(arr_1);
