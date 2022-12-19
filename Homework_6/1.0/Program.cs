//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 
int Nums(int num)
{
    int a = 0;
    for(int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int b = int.Parse(Console.ReadLine());
        if(b > 0) a++;
    }
    return a;
}
Console.Write("Сколько чисел хотите ввести?: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0: {Nums(b)}");
