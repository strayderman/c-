// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int[] myArray)
{
    Console.WriteLine("Введите числа больше или меньше 0:\t ");
       
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = int.Parse(Console.ReadLine()!);
    }
}

void PrintArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"[{i}] = {massiv[i]}  ");
    }
    Console.WriteLine();
}

int FindElements(int[] massiv)
{
    int count = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.Write("Введите количество элементов:\t ");
    int elemenscount = int.Parse(Console.ReadLine()!);
    int[] myArr = new int[elemenscount];
FillArray(myArr);
PrintArray(myArr);
Console.WriteLine();
FindElements(myArr);
Console.WriteLine($"Количество чисел больше 0 -> {FindElements(myArr)}");