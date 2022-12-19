//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Peresechenie(double r1, double b1, double r2, double b2)
{
    double a = r1 - r2;
    if(a != 0)
    {
        double x = (b2-b1) / (r1-r2);
        double y = r1 * x + b1;
        Console.WriteLine($"Точка пересечения: ({x};{y})");
    }
    else if(r1 == r2 && b1 == b2)
    Console.WriteLine("Прямые совпадают");
    else
    Console.WriteLine("У прямых нет точек пересечения");
}
Peresechenie(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
