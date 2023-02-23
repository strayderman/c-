// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Решение №1
// double aPowerb(double a, double b)
// {
//     double c = Math.Pow(a,b);
//     return(c);
// }

// Console.WriteLine("Введите 1-е число: ");
// double a1 = Convert.ToUInt32(Console.ReadLine());
// Console.WriteLine("Введите 2-е число: ");
// double b1 = Convert.ToUInt32(Console.ReadLine());

// Console.WriteLine("Результат возведения 1-го числа в степень 2-го = " + aPowerb(a1, b1));

// Решение №2

int Pow(int a, int b)
{
    int c = 1;
    
}

Console.WriteLine("Введите 1-е число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Результат возведения 1-го числа в степень 2-го = " + Pow(a1, b1));