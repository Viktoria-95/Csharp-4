﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// нужно задать массив равный 8 

Random array = new Random();

int[] n = new int [8];
for (int i = 0; i < n.Length; i++)
{
    n[i] = array.Next(1,19);
    Console.Write($" { n[i] } ");
}




