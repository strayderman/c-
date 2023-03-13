// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


string UserMessage(string message)
{
    return $"Введите количество {message} >>> ";
}

int GetRows()
{
    Console.Write($"{UserMessage("строк")}");
    int rows = Convert.ToInt32(Console.ReadLine());
    return rows;
}

int GetCols()
{
    Console.Write($"{UserMessage("столбцов")}");
    int cols = Convert.ToInt32(Console.ReadLine());
    return cols;
}

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
void GetSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i,k] < array[i, k+1])
                {
                    int temp = array[i,k+1];
                    array[i,k+1] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
}

void Task54()
{
    int rows = GetRows();
    int cols = GetCols();
    int[,] matrix = new int[rows, cols];
    Console.WriteLine($"Полученный массив");
    FillMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine($"Отсортированный массив");
    GetSort(matrix);
    PrintMatrix(matrix);
}
Task54();