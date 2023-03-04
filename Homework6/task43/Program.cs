// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//



double FindX(int k, int b, int k3, int b3)
{
    double x = (b3 - b) / (k - k3); 
return x;
}

double FindY(Double FindX,int k1, int b1)
{
   double y = k1*FindX + b1;
return y;
}

// void task43()
// {
//     double X = FindX();
//     double Y = FindY();
//     Console.WriteLine(X, Y);
// }

// task43();

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
