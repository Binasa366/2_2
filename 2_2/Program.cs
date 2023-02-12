// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.Через строку решать нельзя.
//645 -> 5

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int i = Convert.ToInt32(Math.Log10(num));
if (i > 2)
{
    int stepen = i;
    int num1 = Convert.ToInt32(Math.Pow(10, stepen - 2));
    int num2 = num % num1;
    int num4 = num2 % 10;
    Console.WriteLine($"Третья цифра - {num4}");
}
else
    Console.WriteLine($"Третьей цифры не существует");
