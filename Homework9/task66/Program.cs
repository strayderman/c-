// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число: ");
int Min = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int Max = int.Parse(Console.ReadLine()!);
int sum = 0;
int X = SumRecursion(Min, Max);

Console.WriteLine($"Сумма элементов между {Min} и {Max} = {X}");

int SumRecursion(int min, int max)
{
    if (min <= max)
    {
        sum = sum + max; 
        SumRecursion(min, max - 1);
    }
return sum;
}