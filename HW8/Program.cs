// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GenerateArray(int m, int n)
{
    int[,] randomArray = new int[m,n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = new Random().Next(0, 9+1);
            Console.Write($"{randomArray[i,j],4}");
        }
    }
    Console.WriteLine();
    return randomArray;
}

/*void ChangeRows(int[,] array) // переходы
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      Console.WriteLine();
      for (int j = 0; j < array.GetLength(1); j++)
      {
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;

        Console.Write($"{array[i,j],4}");
      }  
    }
}*/
int [,] mas = GenerateArray(3,4);
Console.WriteLine();
//BubbleSort(mas);

/*int max = array[0,0];

    for (int i = 0; i < array.GetLength(0); i++)
    {    
      Console.WriteLine();
      for (int j = 0; j < array.GetLength(1); j++)
      {
       {
        if(array[0,j]>max) max = array[0,j];
       } 
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(1)+1,j];
        array[array.GetLength(1)+1,j] = temp;
      
        Console.Write($"{array[i,j],4}");
      }
    }  */

//ChangeRows(array);

/*static void BubbleSort(int[] inArray)
//{
    for (int i = 0; i < inArray.GetLength(1); i++)
        for (int j = 0; j < inArray.GetLength(1) - i - 1; j++)
        {
            if (inArray[0,j] > inArray[0,j + 1])
            {
                int temp = inArray[0,j];
                inArray[0,j] = inArray[0,j + 1];
                inArray[0,j + 1] = temp;
            }
            Console.Write($"{inArray[i,j],4}");
        }
    
//}*/

//static int[,] BubbleSort(int[,] mas)
       // {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1)-1; j++)
                {
                    int min = j;
                    for (int k = j+1; k < mas.GetLength(1); k++)
                    {
                    if (mas[k] < mas[j]) 
                    {
                        min = k;
                    }
                    int temp = mas[k,j];
                    mas[k,j] = mas[0,j];
                    mas[0,j] = temp;
                    }   
                 Console.Write($"{mas[i,j], 4}"); 
                }                 
            }
                          
          //  return mas;
       // }