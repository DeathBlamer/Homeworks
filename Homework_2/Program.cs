// Task 10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int SecondNum (int threedigit)
// {
//     int num1 = (threedigit / 10 % 10);
//     return num1;
// }

// System.Console.Write("Введите трёхзначное число -> ");
// int threedigit = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Второе число -> {SecondNum(threedigit)}");



// Task 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int ThirdNum (int number)
// {
//     if (number > 99)
//     {
//         while (number > 999)
//         {
//             number = number / 10;
//         }
//     }
//     int num1 = number % 10;
//     return num1;
// }

// System.Console.Write("Введите число -> ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99)
// {
//     System.Console.WriteLine($"Третья цифра числа {number} -> {ThirdNum (number)}");
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }


// Task 15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool CheckWeekend (int day)
// {
//     if (day == 6 || day == 7) return true;
//     else return false;
// }

// System.Console.Write("Введите день -> ");
// int day = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(CheckWeekend(day));