// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


class GFG //присваиваем класс программы, для возможности использования статического члена - distance
{ // public static void Main - назначаем модификатор, тип и имя функции
    public static void Main() 
{ // считываем вводимые числа с консоли и присваиваем тип float
     Console.Write("Введите координату x1: ");
     float x1 = float.Parse(Console.ReadLine()); // float - тип данных, float.Parse - конвертация данных
     Console.Write("Введите координату y1: ");
     float y1 = float.Parse(Console.ReadLine());
     Console.Write("Введите координату z1: ");
     float z1 = float.Parse(Console.ReadLine());
     Console.Write("Введите координату x2: ");
     float x2 = float.Parse(Console.ReadLine());
     Console.Write("Введите координату y2: ");
     float y2 = float.Parse(Console.ReadLine());
     Console.Write("Введите координату z2: ");
     float z2 = float.Parse(Console.ReadLine());
    distance(x1, y1, z1,
    x2, y2, z2);
}
// static void distance - назначаем модификатор, тип и имя функции
static void distance(float x1, float y1,
                    float z1, float x2,
                    float y2, float z2)
{ //расписываем формулу нахождения растояния между координатами в 3D пространстве
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                        Math.Pow(y2 - y1, 2) +
                        Math.Pow(z2 - z1, 2) *
                        1.0), 0.5);
    Console.WriteLine($"Расстояние между 3 точками в 3D пространстве {d}");
    return;
}
