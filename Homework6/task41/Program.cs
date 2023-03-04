// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = 
  
    }
}

int FindEvenElements(int[] massiv)
{
    int count = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}