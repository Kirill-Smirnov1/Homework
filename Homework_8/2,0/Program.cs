//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
void Smollarr(int[,] arr)
{
    int stroka_size = arr.GetLength(0);
    int stolbi_size = arr.GetLength(1);
    int kolvo = 1000;
    int num;
    int smoll = 0;
    for (int i = 0; i < stroka_size; i++)
    {
        num = 0;
        for (int j = 0; j < stolbi_size; j++)
        
            num += arr[i,j];
            Console.Write($"{num, 4}");
        if(kolvo > num)
        {
            kolvo = num;
            smoll = i;
        }

        
    }
    Console.WriteLine();
    Console.Write($"Строка с наименьшей суммой элементов - {smoll + 1}");
}
Console.Write("Введите количество строк: ");
int stroka = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolb = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(stroka, stolb, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Print(arr_1);
Smollarr(arr_1);
