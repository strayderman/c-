// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите точку X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите точку Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите точку Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите точку X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите точку Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите точку Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double x = Math.Pow((x2-x1), 2);
double y = Math.Pow((y2-y1), 2);
double z = Math.Pow((z2-z1), 2);

double result = Math.Sqrt(x + y + z);
System.Console.WriteLine(result);
