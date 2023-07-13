/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());

if (number < 100 |number > 999)
{
    Console.WriteLine("Некорректное число");
}
else {
    Console.WriteLine(number/10%10);
}*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else {
while (number > 999)
{
   number=number/10;
}
Console.WriteLine(number % 10);
}*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

/*Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());

if (number < 1 | number > 7)
{
    Console.WriteLine("Некорректное число.");
}
if (number >= 1 & number <= 5)
{
    Console.Write("нет");
}
if (number == 6 | number == 7)
{
    Console.Write("да");
}*/