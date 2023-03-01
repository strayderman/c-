// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Метод заполнения массива
void FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(100, 1000);
                Console.Write (mass[i] + " ");
    }
}
// Метод проверки чисел на четность
int FindEvenNumber(int[] massindex)
{
int count = 0;
    for (int j = 0; j < massindex.Length; j++)
    {
                if (massindex[j] % 2 == 0)
        {
            count = count + 1;
            //Console.WriteLine($"Индекс четного числа  {count}");
        }
    }
return count;
}

Console.WriteLine("Введите длинну массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
FillArray(arr);
Console.WriteLine();
Console.WriteLine(FindEvenNumber(arr));


