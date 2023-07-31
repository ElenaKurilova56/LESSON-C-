//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// Console.Write("Введите размер массива: ");
// int M = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[M];
// int count =0;
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"Введите элемент массива c индексом {i}: ");
//     arr[i]=Convert.ToInt32(Console.ReadLine());
//     if (arr[i]>0) count++;
// }
// Console.WriteLine(count);


//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double EnterValue (string text)
// {
//     Console.Write(text);
//     double value = Convert.ToDouble(Console.ReadLine());

//     return value;
// }

// double b1 = EnterValue ("Введите значение b1: ");
// double b2 = EnterValue ("Введите значение b2: ");
// double k1 = EnterValue ("Введите значение k1: ");
// double k2 = EnterValue ("Введите значение k2: ");
// double x = 0;
// double y = 0;
// x = (b2-b1)/(k1-k2);
// y = k1*x+b1;
// Console.Write($"Координаты точки пересечения двух прямых -> ({x},{y})");