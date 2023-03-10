// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            newMatrix[rows, cols] = new Random().Next(0, 50);
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

void PrintMat(double[] mat)
{
    for (int i = 0; i < mat.Length; i++)
        {
            Console.Write($"{mat[i]}\t");
        }
        Console.WriteLine();
}

double[] SumArray(int[,] matrixx)
{
    double[] result = new double[matrixx.GetLength(1)];
    for (int j = 0; j < matrixx.GetLength(1); j++)
    {
        double Sum = 0;
        for (int i = 0; i < matrixx.GetLength(0); i++)
        {
            Sum += matrixx[i, j];
        }
        result[j] = Math.Round(Sum / matrixx.GetLength(0), 2);
    }
    return result;
}
void Task52()
{
    int rows = GetRows();
    int cols = GetCols();
    int[,] matrix = new int[rows, cols];
    FillMatrix(matrix);
    PrintMatrix(matrix);
    SumArray(matrix);
    double[] array = SumArray(matrix);
    Console.Write($" Среднее арифметическое каждого столбца ");
    Console.WriteLine();
     PrintMat(array);
}
Task52();