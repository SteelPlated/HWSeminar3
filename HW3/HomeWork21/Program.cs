/*Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координату x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
double z2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
double result = Math.Round(distance, 2);
Console.WriteLine(result);
