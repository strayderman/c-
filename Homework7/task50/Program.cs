// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по данным индексам такого числа в массиве нет

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

string UserIndexMessage(string message)
{
    return $"Введите  {message} >>> ";
}
int GetIndexRows()
{
    Console.Write($"{UserIndexMessage("индекс строки")}");
    int indRows = Convert.ToInt32(Console.ReadLine());
    return indRows;
}

int GetIndexCols()
{
    Console.Write($"{UserIndexMessage("индекс столбца")}");
    int indCols = Convert.ToInt32(Console.ReadLine());
    return indCols;
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
void FindIndex(int[,] matrixx, int rowsindex, int colsindex)
{
    if (rowsindex - 1 > matrixx.GetLength(0) || colsindex - 1 > matrixx.GetLength(1))
    {
        Console.WriteLine($"Элемента с индексами {rowsindex},{colsindex} - не существует ");
    }
    else
    {
        Console.WriteLine($"Элемент с индексами {rowsindex},{colsindex} - {matrixx[rowsindex - 1, colsindex - 1]}");
    }
}

void Task50()
{
    int rows = GetRows();
    int cols = GetCols();
    int[,] matrix = new int[rows, cols];
    FillMatrix(matrix);
    PrintMatrix(matrix);
    int rowsindex = GetIndexRows();
    int colsindex = GetIndexCols();
    FindIndex(matrix, rowsindex, colsindex);

}
Task50();