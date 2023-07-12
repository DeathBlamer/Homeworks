// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DDoubleArray (int rows, int columns, double minValue, double maxValue)
// {
//     double[,] array = new double[(int)rows, (int) columns];
//     Random random = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = Math.Round((random.NextDouble() * (maxValue - minValue) + minValue), 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == Количество строк в 2D массиве
//     {
//         for (int j = 0; j < array.GetLength(1); j++)// array.GetLength(1) == Количество столбцов в 2D массиве
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// double minValue = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// double maxValue = Convert.ToDouble(Console.ReadLine());
 
// System.Console.WriteLine();
// Print2DArray(Create2DDoubleArray(rows, columns, minValue, maxValue));








// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] Create2DArray (int rows, int columns, int minValue, int maxValue)
// {
//     int [,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == Количество строк в 2D массиве
//     {
//         for (int j = 0; j < array.GetLength(1); j++)// array.GetLength(1) == Количество столбцов в 2D массиве
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElement (int [,] array, int IndexRow, int IndexColumn)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == IndexRow && j == IndexColumn)
//             {
//                 Console.WriteLine($"Find element -> {array[i, j]}");
//             }
            
//         }
//     }
//     if (IndexRow >= array.GetLength(0) || IndexColumn >= array.GetLength(1))
//     {
//         Console.WriteLine("There is no such element");
//     }
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input row element: ");
// int row = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input column element: ");
// int column = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();

// int [,] MyArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(MyArray);

// FindElement(MyArray, row, column);







// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Create2DArray (int rows, int columns, int minValue, int maxValue)
// {
//     int [,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == Количество строк в 2D массиве
//     {
//         for (int j = 0; j < array.GetLength(1); j++)// array.GetLength(1) == Количество столбцов в 2D массиве
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void AverageColumn (int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i,j];
//         }
//         Console.Write($"{ sum / array.GetLength(1)}");
//         if (j < array.GetLength(1) - 1)
//         {
//             System.Console.Write("; ");
//         }
//     }
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
 
// System.Console.WriteLine();

// int [,] MyArray = Create2DArray(rows, columns, minValue, maxValue);

// Print2DArray(MyArray);  

// System.Console.Write("Среднее арифметическое каждого столбца: ");
// AverageColumn (MyArray);
// System.Console.WriteLine(".");