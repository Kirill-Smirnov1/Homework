//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int Summa(int a)
{
    int Itogo = 0;
    a = Math.Abs(a);
    while(a > 0)
    {
        Itogo += a % 10;
        a = a/10;

    }
    return Itogo;
}
Console.WriteLine(Summa(int.Parse(Console.ReadLine())));
