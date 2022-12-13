/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


System.Console.WriteLine("Вводим координаты первой точки: ");
System.Console.Write("Введите координаты точки x: ");
float x = float.Parse(Console.ReadLine()!);
System.Console.Write("Введите координаты точки y: ");
float y = float.Parse(Console.ReadLine()!);
System.Console.Write("Введите координаты точки z: ");
float z = float.Parse(Console.ReadLine()!);

System.Console.WriteLine("Вводим координаты второй точки: ");
System.Console.Write("Введите координаты точки x: ");
float x1 = float.Parse(Console.ReadLine()!);
System.Console.Write("Введите координаты точки y: ");
float y1 = float.Parse(Console.ReadLine()!);
System.Console.Write("Введите координаты точки z: ");
float z1 = float.Parse(Console.ReadLine()!);

/* √ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2*/

float diffx = (x - x1);
float kvatratx = MathF.Pow(diffx, 2);
float diffy = (y - y1);
float kvatraty = MathF.Pow(diffy, 2);
float diffz = (z - z1);
float kvatratz = MathF.Pow(diffy, 2);
float sum = kvatratx + kvatraty + kvatratz;
Console.WriteLine("Расстояние между двумя точками: " + MathF.Round(MathF.Sqrt(sum), 2));