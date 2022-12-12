//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 26
//[-4, -6, 4, 6] -> 0
int [] CreateMass(int size)
{
    int[] arr = new int [size];
    for(int i = 0; i < size; i++)
    arr[i] = new Random().Next(-100,100);
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

int Sum_nechet(int[] arr)
{
    int kol_vo = 0;
    for(int i = 1; i < arr.Length; i = i + 2)
    {
        kol_vo = kol_vo + arr[i];
    }
    return kol_vo;
}
Console.Write("Введите размер массива: ");
int[] arr1 = CreateMass(int.Parse(Console.ReadLine()));
Print(arr1);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива: {Sum_nechet(arr1)}");