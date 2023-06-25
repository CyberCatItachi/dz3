//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//sqrt(pow((x2-x1),2)+pow((y2-y1),2)+pow((z2-z1),2))

Console.Clear();
Console.WriteLine("Введите координаты точки А");
Console.WriteLine("по оси x:");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("по оси y:");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("по оси z:");
int c1 = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введите координаты точки В");
Console.WriteLine("по оси x:");
int a2 = int.Parse(Console.ReadLine());
Console.WriteLine("по оси y:");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("по оси z:");
int c2 = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(a2-a1,2) + Math.Pow(b2-b1, 2) + Math.Pow(c2-c1, 2));
Console.Clear();
Console.WriteLine($"Расстояние от точки А то до точки В - {result:f2}");
