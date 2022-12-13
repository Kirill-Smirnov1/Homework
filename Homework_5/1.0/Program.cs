//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int [] CreateMass(int size)
{
    int[] arr = new int [size];
    for(int i = 0; i < size; i++)
    arr[i] = new Random().Next(100,1000);
    return arr;
}

void Print(int[] arr)
{
    int size = arr.Length;
    for(int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}");
        Console.WriteLine();

    }
}

int Kol_vo_chetn(int[] arr)
{
    int kol_vo = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        kol_vo+=1;
    }
    return kol_vo;
}
Console.Write("Введите размер массива: ");
int[] arr1 = CreateMass(int.Parse(Console.ReadLine()));
Print(arr1);
Console.WriteLine($"Количество четных элементов массива: {Kol_vo_chetn(arr1)}");
