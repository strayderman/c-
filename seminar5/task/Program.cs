// // Задача 39: Напишите программу, которая перевернёт 
// // одномерный массив (последний элемент будет на первом 
// // месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]

// int[] GetArray(int size, int minValue, maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++);
//     {
//         res[i] = new Random().Next(minValue, maxValue);
//     }
//     return res;
// }
// void ReversArray(int inArray) // 
// {
//     for (int i = 0; i < inArray.Lenght/2; i++)
//     {
//         inArray k = inArray[i];
//         inArray = inArray[inArray.Lenght - 1];
//         inArray[inArray.Lenght - 1 - i] = k;
//     }
// }

// int[] ReversArray2(int inArray) 
// {
//     for (int i = 0; i < inArray.Lenght ; i++)
//     {
//         result[i] = 
//     }
//     int result = new int[inArray.Lenght];
// }



    
// #endregion
// int[] array =GetArray(10, 0, 10);
// Console.WriteLine(string.Join(" ", array));
// ReversArray(array);





// // Задача 39: Напишите программу, которая перевернёт 
// // одномерный массив (последний элемент будет на первом 
// // месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue);
//     }
//     return res;
// }

// void ReverseArray1(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - 1 - i];
//         inArray[inArray.Length - 1 - i] = k;
//     }
// }

// int[] ReverseArray2(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];
//     }
//     return result;
// }


// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(string.Join(" ", array));
// //ReverseArray1(array);
// int[] reverseArray = ReverseArray2(array);
// Console.WriteLine(string.Join(" ", reverseArray));
// Console.WriteLine(string.Join(" ", array));


// Задача 40: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с сторонами 
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

// void GetTriangle(int a, int b, int c)
// {
//     if (a > 0 && b > 0 && c > 0)
//     {
//         if (a < b + c && b < a + c && c < a + b)
//         {
//             System.Console.WriteLine("Да");
//         }
//         else
//         {
//             System.Console.WriteLine("нет");
//         }
//     }
// }

// System.Console.WriteLine("Введите стороны треугольника: ");
// int num1 = int.Parse(System.Console.ReadLine());
// int num2 = int.Parse(System.Console.ReadLine());
// int num3 = int.Parse(System.Console.ReadLine());
// GetTriangle(num1, num2, num3);




// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int n = number;
// int remains = 0;
// string res = string.Empty;
// while (number > 0)
// {
//     remains = number % 2;
//     res = remains + res;
//     number = number / 2;

// }
// Console.WriteLine(res);

// Задача 44: Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void Fiboinachi() {
//     Console.Write("Введите длинну массива >>> ");
//     int length = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[length];
//     array[0] = 0;
//     array[1] = 1;
//     int tmp = 0;
//     Console.Write($"{array[0]}\t {array[1]}\t");
//     for (int i = 2; i < length; i++)
//     {
//         array[i] = array[i - 2] + array[i - 1];
//         Console.Write($"{array[i]}\t");
//     }
// }
// Fiboinachi(); 



// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного 
// копирования.

void FillArray(int[] massiv){
    for (int i = 0; i < massiv.Length; i++)
    {
        Random rnd = new Random();
        massiv[i] = rnd.Next(1, 100);
    }
}

void PrintArray(int[] massiv){

    for (int i = 0; i < massiv.Length; i++)
    {
        Console.WriteLine($"[{i}] = {massiv[i]}");
    }
    Console.WriteLine();
}


int[] GetArray(int[] massiv){
    int length = massiv.Length; // Старый массив
    int[] massiv1 = new int[length];// Новый массив
    for (int i = 0; i < length; i++)
    {
        massiv1[i] = massiv[i];
    }
    return massiv1;
}

void DeepCopy(){

    int[] massiv = new int[10];
    FillArray(massiv); // Заполнение массива
    System.Console.WriteLine("\nНаш массив:");
    PrintArray(massiv); // Вывод массива
    int[] newMassiv = GetArray(massiv);
    System.Console.WriteLine("\nНовый массив:");
    PrintArray(newMassiv); // Вывод массива
}