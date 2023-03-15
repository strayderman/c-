// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int y = int.Parse(Console.ReadLine()!);
Akkerman(x, y);
int result = Akkerman(x, y);
Console.WriteLine(result);
int Akkerman(int m, int n)
{
    if (m < 0 || n < 0)
        return -1;
    else if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
}