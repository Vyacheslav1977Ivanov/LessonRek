﻿// Задача 3 : Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы



int[] array = { 3,12,32,4,0,17 };

int num = array.Length - 1;

int ArrayNumsRevers(int num,int[] array)
{
    if (num < 0)
    {
        
        return 0;
    }
    Console.Write($"{array[num]},");
    return  ArrayNumsRevers(num - 1 , array);
}
Console.WriteLine($"Исходный массив: [{array[0]},{array[1]},{array[2]},{array[3]},{array[4]},{array[5]}]");
Console.Write("Перевернутый массив: [");
ArrayNumsRevers(num, array);
Console.Write("]");
