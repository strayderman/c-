// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


// 1 int[,]GetArray(int m, int m, int minValue, maxValue)
// {
//     int[,] result = new int[m,n];
//     for(int i =0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().Next(minValue,maxValue);
//             Console.WriteLine($"{result[i,j]}");
//         }
//         Console.WriteLine();
//     }
//     return result;
// }
// Console.WriteLine("Введите количество строк массива ");
// int rows = int.Parse(Console.WriteLine());
// Console.WriteLine("Введите количество столбцов массива ");
// int colums = int.Parse(Console.WriteLine());

// int[,] array = GetArray(rows,colums, 0, 10) ;

// 2 int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);

// PrintArray(array);






// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле:
//  Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.

m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5

*/

// string UserMessage(string message){
//     return $"Введите количество {message} >>> ";
// }

// int GetRows(){
//     Console.Write($"{UserMessage("строк")}");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     return rows;
// }

// int GetCols(){
//     Console.Write($"{UserMessage("столбцов")}");
//     int cols = Convert.ToInt32(Console.ReadLine());
//     return cols;
// }


// int[,] FillArray(int[,] matrix){
//     int[,] newMatrix = matrix;
//     for (int rows = 0; rows < newMatrix.GetLength(0); rows++)
//     {
//         for (int cols = 0; cols < newMatrix.GetLength(1); cols++)
//         {
//             newMatrix[rows,cols] = rows + cols;
//         }    
//     }
//     return newMatrix;
// }

// void PrintMatrix(int[,] matrix){
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int cols = 0; cols < matrix.GetLength(1); cols++)
//         {
//             Console.Write($"{matrix[rows,cols]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void Task48(){
//     int rows = GetRows();
//     int cols = GetCols();
//     int[,] matrix = new int[rows, cols];
//     FillArray(matrix);
//     PrintMatrix(matrix);
// }

// Task48();






// Задача 49: Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса чётные, 
//  и замените эти элементы на их квадраты.




// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся 
// на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12