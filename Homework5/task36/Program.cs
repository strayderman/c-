// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// метод заполнеия массива
void FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-10, 20);
        Console.Write(mass[i] + " ");
    }
}
int FindSum(int sum, int[]array)
{
    int sum1 = 0;
    for (int j = 1; j < array.Length; j= j+2)
    {
        sum1 = sum1 + array[j];
    }
    return sum1;
} 
Console.WriteLine("Введите длинну массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
FillArray(arr);
Console.WriteLine();
FindSum(sum1, arr);
Console.WriteLine();