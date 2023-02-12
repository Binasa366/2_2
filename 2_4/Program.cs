// Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100. При этом вместо чисел,
//кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. Если число кратно 
//пятнадцати, то программа должна выводить слово FizzBuzz. Задача может показаться очевидной, но нужно получить наиболее 
//простое и красивое решение.

Console.WriteLine("Введите первое число");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n2 = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (n2 < n1)
{
    Console.WriteLine("Ошибка! Первое число меньше второго");
    return;
}
for (int i = n1; i <= n2; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("Fizz", i);

    }
    if (i % 5 == 0)
    {
        Console.WriteLine("Buzz", i);

    }
    if (i % 3 == 0 & i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz", i);

    }
    else
        Console.WriteLine("{0} ", i);
}
