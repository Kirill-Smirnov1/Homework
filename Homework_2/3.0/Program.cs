// Задача 3:
//Напишите программу, которая выводит третью цифру, заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

void Task3()
{
Console.Write("Введите любое целое число: ");
int a = int.Parse(Console.ReadLine());
if (-100 < a && a < 100)
{
   Console.Write($"У {a} нет 3 цифры");
    
}
    else if((-1000 < a && a <= -100) || (a < 1000 && a >= 100))
{
    int d = a % 10;
    Console.Write($"Третья цифра: {Math.Abs(d)}");
    
}
    else if(a >= 1000)
{
   while(a >= 1000) a /= 10; int f = a % 10; 
    Console.Write($"Третья цифра {f}"); 
}
else
{
    while(a <= -1000) a /= 10;  int c = a % 10;
    Console.Write($"Третья цифра {Math.Abs(c)}");
} 
} 
Task3();


