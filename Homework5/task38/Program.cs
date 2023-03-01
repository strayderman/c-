// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// метод заполнеия массива

void FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(0, 100);
        Console.Write($"[{mass[i]}] ");
    }
}

// метод нахождения максимального и минимального
int FindMinMax(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        } 
        else if (array[i] > max)
        {
            max = array[i];
        }
        // Console.WriteLine(min);
        // Console.WriteLine(max);
    }
int dif = max - min;
return dif;
}
//

Console.WriteLine("Введите длинну массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
FillArray(arr);
Console.WriteLine();

Console.WriteLine($"Разница =   {FindMinMax(arr)}");