/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 1; i <= number; i++)
{
   result = i*i*i;
   Console.Write($"{result}, ");
}
Console.Write("\b\b ");*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

//растояние = scrt((x1 - x2) ^ 2 +  (y1 - y2) ^ 2)

/*int enterValue (string prompt)
{
    Console.Write($"Введите координату точки {prompt}");
    int value = Convert.ToInt32(Console.ReadLine());

    return value;
}

int xa = enterValue("a по оси x: ");
int ya = enterValue("a по оси y: ");
int za = enterValue("a по оси z: ");
Console.WriteLine();
int xb = enterValue("b по оси x: ");
int yb = enterValue("b по оси y: ");
int zb = enterValue("b по оси z: ");
Console.WriteLine();

double distance = Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2) + Math.Pow((za-zb),2));
Console.Write($"Расстояние между точками равно:{Math.Round(distance,2)}");*/

/*Console.Write("Введите коордитату xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коордитату ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коордитату za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коордитату xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коордитату yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коордитату zb: ");
int zb = Convert.ToInt32(Console.ReadLine());

int x = (xa-xb)*(xa-xb);
int y = (ya-yb)*(ya-yb);
int z = (za-zb)*(za-zb);

double result = x+y+z;

Console.Write($"Расстояние между точками равно: {Math.Round(Math.Sqrt(result),2)}");*/

/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 | num > 99999)
{
    Console.WriteLine("Число не пятизначное.");
}
else
{
    int figure1 = num / 10000;

    int figure2 = num / 1000 % 10;

    int figure4 = num / 10 % 10;

    int figure5 = num % 10;

    if (figure1 == figure5 & figure2 == figure4)
    {
        Console.WriteLine("Число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом.");
    }
}*/
