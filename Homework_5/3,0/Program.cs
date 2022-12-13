//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
double [] CreateMass(int size, int from, int to)
{
    double[] arr = new double [size];
    Random n_new = new Random();
    for(int i = 0; i < size; i++)
    arr[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);
    return arr;
}

void Print(double[] arr)
{
    int size = arr.Length;
    for(int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}");
        Console.WriteLine();

    }
}
void Search(double[] arr)
{
    double max = arr [0];
    double min = arr [0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(max < arr[i])
        max = arr[i];
        else if(min > arr[i])
        min = arr[i];
        //Console.Write($"Максимальное число: {max}, минимальное число: {min}.");
        //Console.WriteLine($"Разница: {max} - {min} = {Math.Round(max - min, 2)}");
    }
    Console.Write($"Максимальное число: {max}. Минимальное число: {min}.");
    Console.WriteLine($"Разница: {max} - {min} = {Math.Round(max - min, 2)}");
}
double[] arr1 = CreateMass(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Print(arr1);
Search(arr1);
