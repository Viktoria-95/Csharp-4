// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// нужно задать массив равный 8 

Random array = new Random();
Console.WriteLine("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] n = new int [lenght];
for (int i = 0; i < n.Length; i++)
{
    n[i] = array.Next(0, 100);
    Console.Write($" { n[i] } ");
}


// int[] GetArray(int lenght)
// {
//     int[] array = new int[lenght];
//     for (int i = 0; i < lenght; i++)
//         array[i] = new Random().Next(100, 1001);
//     Console.WriteLine(string.Join(",", array));
//     return array;
// }
