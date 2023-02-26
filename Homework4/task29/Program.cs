// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Метод заполнения массива
void FillArray(int[] mass) 
{
    int length = mass.Length;
    int index = 0;
    while (index < length)
    {
        mass[index] = new Random().Next(1, 20);
        index++; //index = index + 1;
    }

}

//Метод вывода массива
void PrintArray(int[] mas)
{
    int count = mas.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(mas[position] + " ");
        position++;
    }
}
int[] array = new int[8];
FillArray(array);
Console.WriteLine();
PrintArray(array); 

