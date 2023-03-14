// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

// метод заполнения массива
int[,] FillMatrix(int[,] matr)
{
    int[,] newMatrix = matr;
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matr.GetLength(1); cols++)
        {
            newMatrix[rows, cols] = new Random().Next(1, 10);
        }
    }
    return newMatrix;
}
void PrintMatrix(int[,] mat)
{
    for (int rows = 0; rows < mat.GetLength(0); rows++)
    {
        for (int cols = 0; cols < mat.GetLength(1); cols++)
        {
            Console.Write($"{mat[rows, cols]}\t");
        }
        Console.WriteLine();
    }
}
int GetStringSum(int[,] array)
{
    int row = 0;
    int minSum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0,i];
    }
        for (int j = 1; j < array.GetLength(0); j++)
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum = sum + array[j,k];
                if (minSum > sum)
                {
                    minSum = sum;
                    row = j;
                }
            }
        }
    return row;
}

void Task56()
{
    
    int[,] matrix = new int[3, 4];
    
    FillMatrix(matrix);
    PrintMatrix(matrix);
    GetStringSum(matrix);
    Console.WriteLine($"Индекс строки с наименьшей суммой чисел - {GetStringSum(matrix)}");
}
Task56();