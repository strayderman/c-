// Задача 58: Задайте две матрицы. Напишите программу, 
//  будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetMatrix(int a, int b)
{
    int[,] newMatrix = new int[a, b];
    for (int rows = 0; rows < a; rows++)
    {
        for (int cols = 0; cols < b; cols++)
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
            Console.Write($"{mat[rows, cols]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiMatrix(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int colsB = matrixB.GetLength(1);
    int[,] result = new int[rowsA, colsB];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int n = 0; n < matrixA.GetLength(1); n++)
                {
                    result[i,j] += matrixA[i,n] * matrixB[n,j]; 
                }
            }
        }
    }
    return result;
}

void Task58()
{
    int[,] matrixA = GetMatrix(2,2);
    Console.WriteLine($"Первая матрица");
    PrintMatrix(matrixA);
    //  Console.WriteLine();
    int[,] matrixB = GetMatrix(2,2);
    Console.WriteLine($"Вторая матрица");
    PrintMatrix(matrixB);
    //  Console.WriteLine();
    MultiMatrix(matrixA, matrixB);
    Console.WriteLine($"Результирующая матрица ");
    int[,] matrixResult = MultiMatrix(matrixA, matrixB);
    PrintMatrix(matrixResult);

}

Task58();