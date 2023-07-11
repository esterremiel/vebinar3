// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве
// A(3,6,8); B(2,1,-7) -> 15.84
// A(7,-5,0) B(1,-1,9) -> 11.53

Console.Clear();
Console.Write("A по оси X: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("A по оси Y: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("A по оси Z: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("B по оси X: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("B по оси Y: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("B по оси Z: ");
double z2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 -z1, 2));
Console.WriteLine($"d = {d:f2}");





