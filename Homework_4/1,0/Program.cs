//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
double Cube(int a, int b)
{
    double a3 = 1;
    int b3 = Math.Abs(b);
    for (int i = 1; i <= b3; i++)
    {
        if (b > 0)
            a3 *= a;
        else
            a3 /= a;
    }
    return a3;
}
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(Cube(num1, num2));
