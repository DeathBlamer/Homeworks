// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     } 
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]);
//         if (i < array.Length - 1)
//         {
//             System.Console.Write(", ");
//         }
//     }
//     System.Console.Write("]");
//     System.Console.WriteLine();
// }

// int QuanNum (int[] array)
// {
//     int current = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//              current ++;
//         }
//     }
//     return current;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);

// PrintArray(myArray);

// System.Console.WriteLine($"В этом массиве количество четных чисел = {QuanNum (myArray)}");





// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     } 
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]);
//         if (i < array.Length - 1)
//         {
//             System.Console.Write(", ");
//         }
//     }
//     System.Console.Write("]");
//     System.Console.WriteLine();
// }

// int SumNum (int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1)
//         {
//              sum += array[i];
//         }
//     }
//     return sum;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();

// int [] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// System.Console.WriteLine($"В этом массиве сумма элементов, стоящих на нечетных позициях = {SumNum (myArray)}");





// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным из элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



// double [] CreateRandomArray(int size, double minValue, double maxValue)
// {
//     double[] array = new double[(int)size];
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round((random.NextDouble() * (maxValue - minValue) + minValue), 2);
//     }
//     return array;
// }

// void PrintArray(double[] array)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]);
//         if (i < array.Length - 1)
//         {
//             System.Console.Write(", ");
//         }
//     }
//     System.Console.Write("]");
//     System.Console.WriteLine();
// }

// double DiffArray (double[] array)
// {   
//     double max = array[0];
//     double min = array[0];
//     double diff = 0;
//     for (int i = 0; i < array.Length; i++)
//     {

//         if (max < array [i])
//         {
//             max = array [i];
//         }
//         else
//         {
//             if (min > array [i])
//             {
//                 min = array [i];
//             }
//         }    
//     }
//     diff = Math.Round((max - min), 2);
//     return diff;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// double minValue = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// double maxValue = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine();

// double[] myArray = CreateRandomArray(size, minValue, maxValue);
// double diff = DiffArray (myArray);

// PrintArray(myArray);
// System.Console.WriteLine($"Разница между минимальным и максимальным элементами массива = {diff}");
