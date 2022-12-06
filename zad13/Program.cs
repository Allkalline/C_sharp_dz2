//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

while (a > 999)
{ a = a / 10; }
if (a > 99 & a < 999)
{
    a = a % 10;
    Console.WriteLine($"Третья цифра заданного числа: {a}");
}
else { Console.WriteLine("Третьей цифры нет"); }
