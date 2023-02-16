// Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz», 
// а вместо чисел, кратных пяти — слово «Buzz». Если число кратно и 3, и 5, 
// то программа должна выводить слово «FizzBuzz».
// (доп задача по желанию, разберем на семинаре)


// int[] a = new int[16]; 
// int q = a.Length;
// // string F = "Fizz,";
// // string B = "Buzz,";
// // string FB = "FizzBuzz,";
// for (int i = 1; i < q; i++)// Заполнили массив 
// {
//     a[i] = i + 1;
        
//     if(a[i] % 3 == 1)    // Проверяем кратность 3)
//     { 
//         Console.Write("Fizz,");
//     }
//     if(a[i] % 5 == 1)    // Проверяем кратность 5)
//      {
//         Console.Write("Buzz,");
//      }
//      if (a[i] % 3 == 1 && a[i] % 5 == 1) // Проверяем кратность и 3 и 5)
//      {
//         Console.Write("FizzBuzz,");
//      }
//      else
//         {
//             Console.Write(i + ",");
//         }
   
// }

// int[] a = new int[16]; 
// int q = a.Length;
// for (int i = 0; i < 15; i++)// Заполнили массив 
// {
//     int a = i++;
//     if(a % 3 == 0)    // Проверяем кратность 3)
//     { 
//         Console.Write("Fizz,");
//     }
//        if(a % 5 == 0)    // Проверяем кратность 5)
//      {
//         Console.Write("Buzz,");
//      }
//           if (a % 3 == 0 && a % 5 == 0) // Проверяем кратность и 3 и 5)
//      {
//         Console.Write("FizzBuzz,");
//      }
//      else
//         {
//             Console.Write(a + ",");
//         }
// }


// string F = "Fizz,";
// string B = "Buzz,";
// string FB = "FizzBuzz,";


// for (int i = 0; i < 15; i++)// Заполнили массив 
// {
//     int a = i++;
//    if (a % 3 == 0 && a % 5 == 0) // Проверяем кратность и 3 и 5)
//         {
//         Console.Write("FizzBuzz,");
//         }
//     if(a % 3 == 0)    // Проверяем кратность 3)
//     { 
//         Console.Write("Fizz,");
//     }
//          if(a % 5 == 0)    // Проверяем кратность 5)
//         {
//         Console.Write("Buzz,");
//         }
          
//      else
//         {
//             Console.Write(a + ",");
//         }
// }
int a = 6;
int b = 3;
Console.Write (a % 3 );