// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int [] mArray (int size)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.WriteLine($"Input number M {i + 1}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//         if (i == array.Length -1) {System.Console.WriteLine();}
//     }
//     return array;
// }

// int DiffArray (int [] array)
// {   
//     int current = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             current++;
//         }
//     }
//     return current;
// }

// void PrintArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// System.Console.Write(array[i]);
// if (i < array.Length - 1) {System.Console.Write(", ");}
// if (i == array.Length -1) {System.Console.Write(" -> ");}
// }
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();

// int [] numbers = mArray (size);

// PrintArray(numbers);

// System.Console.Write($"{DiffArray(numbers)}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double PointIntersection(double b1, double k1, double b2, double k2)
{
    yDot =
}