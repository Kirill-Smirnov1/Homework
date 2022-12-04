//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
void Cube(int n)
{
    double[] nams = new double[n];
    int i = 0;
    Console.Write($"{n} таблица кубов: ");
    while(i < n)
    {
        nams[i] = Math.Pow((i + 1), 3);
        Console.Write($"{nams[i]} ");
        i +=1;
    }
    Console.WriteLine();

}
Cube(int.Parse(Console.ReadLine()));

