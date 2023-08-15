/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

// int EnterValue (string text)  
// 	{
//     	Console.Write(text);
//     	int value = Convert.ToInt32(Console.ReadLine());

//     	return value;
// 	}

//  void GenerateArray(int m, int n)
//  {
//      double[,] randomArray = new double[m,n];
//      for (int i = 0; i < randomArray.GetLength(0); i++)
//      {
//         Console.WriteLine();
//         for (int j = 0; j < randomArray.GetLength(1); j++)
//          { 
//             randomArray[i,j] = Math.Round(new Random().NextDouble() * 10, 1);
//             Console.Write($"{randomArray[i,j]}  ");
//          }

//     }
//  }
// int m = EnterValue("Введите число m в размере массива: ");
// int n = EnterValue("Введите число n в размере массива: ");
// GenerateArray(m,n);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// 11 -> 9

/*int EnterValue (string text)  
	{
    	Console.Write(text);
    	int value = Convert.ToInt32(Console.ReadLine());

    	return value;
	}  

int[,] Arr(int m,int n)
{
    int[,] randomArray = new int[m,n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = new Random().Next(-9,9+1);
            Console.Write($"{randomArray[i,j],4}");
        }
        Console.WriteLine();
    }
    return randomArray;
}

int[,] arr = Arr (3,4);
int x = EnterValue("Введите индекс строки: ");
int y = EnterValue("Введите индекс столбца: ");

 if (x <= arr.GetLength(0)-1 && y <= arr.GetLength(1)-1 )
{
  Console.Write($"Значение элемента на заданной позиции: {arr[x,y]}");
}
else
{
  Console.Write("Такого числа в массиве нет");
}*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
          
int[,] Arr(int m,int n)
{
    int[,] randomArray = new int[m,n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = new Random().Next(0,9+1);
            Console.Write($"{randomArray[i,j],4}");
        }
        Console.WriteLine();
    }
    return randomArray;
}

int[,] arr = Arr(3,4);
double sum = 0;
double num = 0;
for (int j = 0; j < arr.GetLength(1); j++)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
      sum = sum+arr[i,j];
  }
  num = sum/arr.GetLength(0);
  Console.Write($"{num} ");
  sum = 0; num = 0;
}
