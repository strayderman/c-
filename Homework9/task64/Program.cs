// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа  в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число - ");
int N = int.Parse(Console.ReadLine()!);
PrintRecursion(N);
Console.Write($"-> {N}{PrintRecursion(N - 1)}");
string PrintRecursion(int number)
{
    if (number == 0)
    {
        return String.Empty;
    }
    else
    {
        return $"{number}{PrintRecursion(number - 1)}";
    }
}
