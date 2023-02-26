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
// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

// Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadInt("Введите число: ");
int numberB = ReadInt("Введите степень: ");
ToDegree(numberA, numberB);