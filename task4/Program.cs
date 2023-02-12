Console.WriteLine("Введите цифру: ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите цифру: ");
int b = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите цифру: ");
int c = Convert.ToInt32(Console.ReadLine()); 
int max = a;
if(b > max) 
{max = b;}
if(c > max) 
{max = c;}
Console.WriteLine("Максимальное число: ");
Console.WriteLine(max);