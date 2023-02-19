// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите N: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    double x = Math.Pow(i,3);
    System.Console.Write(x + " ");
}
