// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
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
//             System.Console.Write((i, j) + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] SortArray(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
//                     temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
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

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);

// Print2DArray(SortArray(myArray));






// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьше суммой элементов: 1 строка.

// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
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

// int FindRowMin(int[,] array)
// {
//     int sum = 0;
//     int minSum = 0;
//     int rowMin = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (i == 0)
//         {
//             minSum = sum;
//         }
//         if (sum < minSum)
//         {
//             minSum = sum;
//             rowMin = i + 1;
//         }
//     }
//     return rowMin;
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

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);

// Console.WriteLine($"Строка с наименьшей суммой элементов -> {FindRowMin(myArray)}");






// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
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

// int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
//     {
//         int rowsA = matrixA.GetLength(0);
//         int colsA = matrixA.GetLength(1);
//         int rowsB = matrixB.GetLength(0);
//         int colsB = matrixB.GetLength(1);

//         if (colsA != rowsB)
//         {
//             Console.WriteLine("Несовместимые размеры матриц для умножения.");
//         }

//         int[,] resultMatrix = new int[rowsA, colsB];

//         for (int i = 0; i < rowsA; i++)
//         {
//             for (int j = 0; j < colsB; j++)
//             {
//                 for (int k = 0; k < colsA; k++)
//                 {
//                     resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
//                 }
//             }
//         }

//         return resultMatrix;
//     }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();

// int[,] matrixA = Create2DArray(rows, columns, minValue, maxValue);
// int[,] matrixB = Create2DArray(rows, columns, minValue, maxValue);

// Print2DArray(matrixA);
// Print2DArray(matrixB);
// Print2DArray(MultiplyMatrices(matrixA, matrixB));




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[, ,] Create3DArray(int rows, int columns, int depth, int minValue, int maxValue)
// {
//     int[, ,] array = new int[rows, columns, depth];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             for (int k = 0; k < columns; k++)
//             {
//             array[i, j, k] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     }
//     return array;
// }

// void Print3DArray(int[, ,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == Количество строк в 3D массиве
//     {
//         for (int j = 0; j < array.GetLength(1); j++)// array.GetLength(1) == Количество столбцов в 3D массиве
//         {

//             for (int k = 0; k < array.GetLength(2); k++)// array.GetLength(2) == Количество глубины в 3D массиве
//             {
//                 System.Console.Write(array[j, k, i] + " ");
//                 System.Console.Write((j, k, i) + " ");
//             }
//                 System.Console.WriteLine();
//         }
//     }
// }

// int rows = 2;
// int columns = 2;
// int depth = 2;
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();

// int[, ,] array3D = Create3DArray(rows, columns, depth, minValue, maxValue);

// Print3DArray(array3D);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void spiralArray()
// {
//     int n = 4;
//     int[,] spiralArray = new int[n, n];

//     int value = 1;
//     int rowStart = 0, rowEnd = n - 1;
//     int colStart = 0, colEnd = n - 1;

//     while (value <= n * n)
//     {
//         // Заполнение верхней строки
//         for (int i = colStart; i <= colEnd; i++)
//         {
//             spiralArray[rowStart, i] = value++;
//         }
//         rowStart++;

//         // Заполнение правого столбца
//         for (int i = rowStart; i <= rowEnd; i++)
//         {
//             spiralArray[i, colEnd] = value++;
//         }
//         colEnd--;

//         // Заполнение нижней строки
//         for (int i = colEnd; i >= colStart; i--)
//         {
//             spiralArray[rowEnd, i] = value++;
//         }
//         rowEnd--;

//         // Заполнение левого столбца
//         for (int i = rowEnd; i >= rowStart; i--)
//         {
//             spiralArray[i, colStart] = value++;
//         }
//         colStart++;
//     }

//     // Вывод массива на экран
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(spiralArray[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// spiralArray();