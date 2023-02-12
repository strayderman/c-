// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите цифру: ");
int a = Convert.ToInt32(Console.ReadLine()); //int.Parse(Console.ReadLine());
Console.WriteLine("Введите цифру: ");
int b = Convert.ToInt32(Console.ReadLine()); //int.Parse(Console.ReadLine());
if (a > b)
 {Console.WriteLine("Большее число: ");
 Console.WriteLine(a);
 Console.WriteLine("Меньшее число: ");
 Console.WriteLine(b);} 
 if(a < b)
 {Console.WriteLine("Большее число: ");
 Console.WriteLine(b);
 Console.WriteLine("Меньшее число: ");
 Console.WriteLine(a);}