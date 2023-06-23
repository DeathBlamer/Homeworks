// Task 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool FiveNumber(int fivenum)
// {
//     {
//         if(fivenum / 10000 == fivenum % 10)
//         if(fivenum / 1000 % 10 == fivenum / 10 % 10)
//         return true;
//     }
//     return false;
// }


// System.Console.WriteLine("Введите пятизначное число: ");
// int fivenum = Convert.ToInt32(Console.ReadLine());

// if (fivenum > 9999 && fivenum < 100000 || fivenum < -9999 && fivenum > -100000)
// {
//     System.Console.WriteLine(FiveNumber(fivenum));
// }
// else 
// {
//     System.Console.WriteLine($"Число {fivenum} не пятизначное!");
// }



// Task 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
// }

// System.Console.WriteLine("Input X coordinate poin A: ");
// double xa = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input Y coordinate poin A: ");
// double ya = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input Z coordinate poin A: ");
// double za = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input X coordinate poin B: ");
// double xb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input Y coordinate poin B: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input Z coordinate poin B: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Distance between points A and B -> {FindDistance(xa, ya, za, xb, yb, zb)}");




// Task 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void NCube(int n)
// {
   
//    for (int i = 1 ; i <= n; i++)
//    {
//         System.Console.WriteLine($"{i} -> {Math.Pow(i, 3)}");
//    }
// }

// System.Console.Write("Введите N -> ");
// int n = Convert.ToInt32(Console.ReadLine());

// NCube(n);