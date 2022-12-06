// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int a = int.Parse(Console.ReadLine()!);

if (a>7 || a<1){Console.WriteLine("Введите число от 1 до 7");}
else if (a<6) {Console.WriteLine("нет");}
else
{Console.WriteLine("да");}