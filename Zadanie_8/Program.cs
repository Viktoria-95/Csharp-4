// Задача 16 - Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите 2 числа ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int a = num1;
int b = num2;
if (a * a == b)
    Console.WriteLine("Да ");
    else if (b * b == a)
    Console.WriteLine("Да ");
    else Console.WriteLine("Нет ");
