Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c =Convert.ToInt32(Console.ReadLine());
int max = a;
while (b > max)
{
    max = b;

}
if (c > max)
{
    max = c;
}
else
{
    max = a;
}

Console.WriteLine("Максимальным из трех чисел является " + max);