Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
int n = int.Parse(a);
int negn = -n;

while(negn <= n)
{
    Console.Write($"{negn}");
    negn +=1;
}
