// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//



double FindX(int k1, int b1, int k2, int b2)
{
    double x1 = b2 - b1;
    double x2 = k1 - k2;
    double x = x2 / x1;
    return x;
}

double FindY(int k1, Double FindX, int b1)
{
    double y = k1 * FindX + b1;
    return y;
}


Console.WriteLine("Введите координаты 1-й прямой: ");
Console.Write("1-я точка >>> ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2-я точка >>> ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты 2-й прямой: ");
Console.Write("1-я точка >>> ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("2-я точка >>> ");
int k2 = Convert.ToInt32(Console.ReadLine());
double X = FindX(b1, k1, b2, k2);
double Y = FindY(k1, X, b1);
Console.WriteLine($"({X};{Y})");
