// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int N = int.Parse(Console.ReadLine());
// int start = 1;
// Concequense(N, start);
// // for (int i = 1; i <= N; i++)
// // {
// //     Console.Write($"{i} ");
// // }

// void Concequense(int number, int start)
// {
//     if (start <= number)
//     {
//         Console.Write($"{start} ");
//         Concequense(number, start + 1);
//     }
// }
// 2 метод строковый
// string Concequense(int number)
// {
//     if (number == 0) return String.Empty;
//     else return $"{Concequense(number - 1)}{number} ";
// }



// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"










Эльвира 21:39
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
Console.WriteLine(SumNums(number, sum));

int SumNums(int num, int sum)
{
    if (num == 0) return sum;
    else
    {
        sum += num % 10;
        return SumNums(num / 10, sum);
    }
}

Console.Clear();
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine($"{m}->{SumNumbers(m)}");

int SumNumbers(int number)
{
    if (number == 0) return 0;
    return (number % 10 + SumNumbers(number / 10));
}

// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Задайте число: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Задайте степень: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine(Pow(A, B));

int Pow(int a, int b)
{
    if (b == 0) return 1;
    else return a * Pow(a, b - 1);
}