//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[num];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write($"{array[i]}, ");  
    
    if (array[i] % 2 == 0) count++;
   
}
Console.Write("\b\b]");
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {count}");*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*int sum = 0;
int[] array = new int[6];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);
    Console.Write($"{array[i]}, ");  
    
    if (i % 2 != 0) sum=sum+array[i];
   
}
Console.Write("\b\b]");
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

/*int[] array = new int[5];
int max = array[0];
int min = array[0];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);
    Console.Write($"{array[i]}, ");

    if (array[i] > max) max = array[i]; 
    if (array[i] < min) min = array[i];      
}

Console.Write("\b\b]");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max-min}");*/
