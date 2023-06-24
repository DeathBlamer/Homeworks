// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int DegreeNum (int a, int b)
// {   
//     int deg = 1;
//     for (int i = 0; i < b; i++)
//     {
//         deg = deg * a;
//     }
//     return deg;
// }

// bool ValidateB (int b)
// {
//     if (b < 0)
//     {
//         System.Console.WriteLine($"Число {b} не может быть меньше нуля!");
//         return false;
//     }
//     return true;
// }

// System.Console.Write("Input number A -> ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input number B -> ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(ValidateB(b))
// {
//     System.Console.WriteLine($"Число {a} в степени {b} -> {DegreeNum(a, b)}");
// }





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumDigits (int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum += num % 10;
//         num = num / 10;
//     }
//     return sum;
// }

// System.Console.Write("Input number -> ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"The sum of the digits in a number {num} = {SumDigits(num)}");




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]);
//         if (i < array.Length - 1)
//         {
//             System.Console.Write(", ");
//         }
//     }
//     System.Console.Write("");
// }

// System.Console.Write("Input array size -> ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("[");
// PrintArray(CreateRandomArray(size, minValue, maxValue));
// System.Console.Write("]");