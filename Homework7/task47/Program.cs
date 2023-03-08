// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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


double[,] FillArray(double[,] matrix)
{
    double[,] newMatrix = matrix;
    for (int rows = 0; rows < newMatrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < newMatrix.GetLength(1); cols++)
        {
            newMatrix[rows, cols] = Math.Round(new Random().Next(-114, 115) * 0.1, 2);
        }
    }
    return newMatrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            Console.Write($"{matrix[rows, cols]}\t");
        }
        Console.WriteLine();
    }
}

void Task47()
{
    int rows = GetRows();
    int cols = GetCols();
    double[,] matrix = new double[rows, cols];
    FillArray(matrix);
    PrintMatrix(matrix);
}

Task47();