﻿// Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz», 
// а вместо чисел, кратных пяти — слово «Buzz». Если число кратно и 3, и 5, 
// то программа должна выводить слово «FizzBuzz».
// (доп задача по желанию, разберем на семинаре)

//string a = Console.WriteLine("Fizz")
int[] a = new int[16]; 
int q = a.Length;
for (int i = 1; i < q; i++)// Заполнили массив от 1 до 15
{
    a[i] = i + 1;
    //Console.WriteLine(i);
    if(a[i] % 3 == 0 && a[i] % 5 == 0)
    {
        
        string b = "FizzBuss";
        int b1 = Convert.ToInt32(b);
        a[i] = b1;
        Console.WriteLine(i);
    }
}