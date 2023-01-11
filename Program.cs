// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введите пятизначное число");
// string number = (Console.ReadLine()!); 
// int len = number.Length;
// if (number.Length == 5)
// {
// if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine("Палиндром");
//     }
//     else
//     {
//         Console.WriteLine("Нe палиндром");
//     }
// }
// else
// {
//     Console.WriteLine("Это не пятизначное число!");
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// ((x1 - x2)^2 + (y1-y2)^2)^(1/2)

// System.Console.Write("Введите координату x точки А: ");
// int x1 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.Write("Введите координату y точки А: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координату z точки A: ");
// int z1= Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координату x точки B: "); 
// int x2 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.Write("Введите координату y точки B: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координату z точки B: ");
// int z2= Convert.ToInt32(Console.ReadLine());
// double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2)),2); 
// System.Console.WriteLine($"Расстояние между двумя точками: {result}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// System.Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i <= x; i++)
// {
// System.Console.WriteLine(Math.Pow(i, 3));
// }
// int count = 1;
// while(count <= x)
// {
// System.Console.Write(Math.Pow(count, 3)+" ");
// count++;
// }
